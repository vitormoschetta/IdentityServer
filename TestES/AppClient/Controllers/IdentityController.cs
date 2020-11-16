using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using IdentityModel.Client;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace AppClient.Controllers
{
    public class IdentityController : Controller
    {
        private readonly ILogger<IdentityController> _logger;

        public IdentityController(ILogger<IdentityController> logger)
        {
            _logger = logger;
        }


        public async Task<dynamic> Index()
        {
            ViewBag.Error = "";
            var client = new HttpClient();

            var disco = await client.GetDiscoveryDocumentAsync("https://localhost:5001"); // server auth

            // request token
            var tokenResponse = await client.RequestClientCredentialsTokenAsync(new ClientCredentialsTokenRequest
            {
                Address = disco.TokenEndpoint,
                ClientId = "client",
                ClientSecret = "secret",

                // Lá no Identity Server o 'client' tem acesso as APIs: 'api01' e 'api02'.
                // Podemos, porém, limitar o escopo de acesso desse client à api01:
                //Scope = "api01"                  
            });

            if (tokenResponse.IsError)
                ViewBag.Error = tokenResponse.Error;

            var result = tokenResponse.Json;


            // call api
            var apiClient = new HttpClient();
            apiClient.SetBearerToken(tokenResponse.AccessToken);            

            var response = await apiClient.GetAsync("https://localhost:6001/Identity"); // app resource
            if (!response.IsSuccessStatusCode)
            {
                return response.StatusCode;
            }
            else
            {
                return await response.Content.ReadAsStringAsync();
            }

        }

    }
}