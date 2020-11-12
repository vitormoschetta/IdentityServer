// Copyright (c) Brock Allen & Dominick Baier. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.


using IdentityServer4.Models;
using System.Collections.Generic;

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
        new List<ApiScope>
        {
            new ApiScope("api1", "My API")
        };

        public static IEnumerable<Client> Clients =>
           new List<Client>
           {
                new Client
                {
                    ClientId = "client",

                    // nenhum usuário interativo, use o clientid / secret para autenticação
                    AllowedGrantTypes = GrantTypes.ClientCredentials,

                    // segredo para autenticação
                    ClientSecrets =
                    {
                        new Secret("secret".Sha256())
                    },

                    // escopos aos quais o cliente tem acesso
                    AllowedScopes = { "api1" }
                }
           };
    }
}