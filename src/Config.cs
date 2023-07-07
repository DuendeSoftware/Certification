using Duende.IdentityServer.Models;
using IdentityModel;

namespace Certification;

public static class Config
{
    public static IEnumerable<IdentityResource> IdentityResources =>
        new IdentityResource[]
        {
            new IdentityResources.OpenId(),
            new IdentityResources.Profile(),
            new IdentityResources.Email(),
            new IdentityResources.Phone(),
            new IdentityResources.Address(),
        };

    public static IEnumerable<Client> Clients =>
        new Client[]
        {
            new Client
            {
                ClientId = "implicit",
                AllowedGrantTypes = GrantTypes.Implicit,

                RedirectUris = { "https://www.certification.openid.net/test/a/duende-op/callback" },
                FrontChannelLogoutUri = "https://localhost:44300/signout-oidc",
                PostLogoutRedirectUris = { "https://localhost:44300/signout-callback-oidc" },
                    
                AllowedScopes = { "openid", "profile", "email", "phone", "address" }
            },
            
            new Client
            {
                ClientId = "code",
                ClientSecrets =
                    {
                        new Secret("secret".ToSha256())
                    },
                
                AllowedGrantTypes = GrantTypes.Code,

                RedirectUris = { "https://www.certification.openid.net/test/a/duende-op/callback" },
                FrontChannelLogoutUri = "https://localhost:44300/signout-oidc",
                PostLogoutRedirectUris = { "https://localhost:44300/signout-callback-oidc" },
                    
                AllowOfflineAccess = true,
                AllowedScopes = { "openid", "profile", "email", "phone", "address" }
            },
            
            new Client
            {
                ClientId = "hybrid",
                ClientSecrets =
                {
                    new Secret("secret".ToSha256())
                },
                
                AllowedGrantTypes = GrantTypes.Hybrid,

                RedirectUris = { "https://www.certification.openid.net/test/a/duende-op/callback" },
                FrontChannelLogoutUri = "https://localhost:44300/signout-oidc",
                PostLogoutRedirectUris = { "https://localhost:44300/signout-callback-oidc" },
                    
                AllowOfflineAccess = true,
                AllowedScopes = { "openid", "profile", "email", "phone", "address" }
            },
        };
}
