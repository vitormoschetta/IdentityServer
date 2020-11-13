using IdentityServer4.Models;
using System.Collections.Generic;
using IdentityServer4.Test;

namespace ServerAuth
{
    public static class Config
    {
        public static IEnumerable<IdentityResource> IdentityResources =>
            new IdentityResource[]
            {
                new IdentityResources.OpenId()
            };

        public static IEnumerable<ApiScope> ApiScopes =>
        new List<ApiScope>                          // <-- Recursos/APIs que desejamos proteger 
        {
            new ApiScope("api01", "My API")
        };

        public static IEnumerable<Client> Clients =>
           new List<Client>                         // <-- Clientes/App que podem acessar nossas (determinadas) APIs protegidas
           {
                new Client
                {
                    ClientId = "client",
                    AllowedGrantTypes = GrantTypes.ClientCredentials,
                    ClientSecrets =
                    {
                        new Secret("secret".Sha256())
                    },
                    AllowedScopes = { "api01" }     // <-- Recursos/APIs ao qual este cliente terá acesso
                }
           };

        public static List<TestUser> GetUsers =>
            new List<TestUser>
            {
                new TestUser
                {
                    SubjectId = "1",
                    Username = "alice",
                    Password = "password"
                },
                new TestUser
                {
                    SubjectId = "2",
                    Username = "bob",
                    Password = "password"
                }
            };

    }
}