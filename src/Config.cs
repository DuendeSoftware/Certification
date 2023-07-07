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
                PostLogoutRedirectUris = { "certification.openid.net/test/a/duende-op/post_logout_redirect" },
                    
                FrontChannelLogoutUri = "https://localhost:44300/signout-oidc",
                FrontChannelLogoutSessionRequired = true,
                
                BackChannelLogoutUri = "certification.openid.net/test/a/duende-op/backchannel_logout",
                BackChannelLogoutSessionRequired = true,
                
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
                PostLogoutRedirectUris = { "certification.openid.net/test/a/duende-op/post_logout_redirect" },
                    
                FrontChannelLogoutUri = "https://localhost:44300/signout-oidc",
                FrontChannelLogoutSessionRequired = true,
                
                BackChannelLogoutUri = "certification.openid.net/test/a/duende-op/backchannel_logout",
                BackChannelLogoutSessionRequired = true,
                    
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
                PostLogoutRedirectUris = { "certification.openid.net/test/a/duende-op/post_logout_redirect" },
                    
                FrontChannelLogoutUri = "https://localhost:44300/signout-oidc",
                FrontChannelLogoutSessionRequired = true,
                
                BackChannelLogoutUri = "certification.openid.net/test/a/duende-op/backchannel_logout",
                BackChannelLogoutSessionRequired = true,
                    
                AllowOfflineAccess = true,
                AllowedScopes = { "openid", "profile", "email", "phone", "address" }
            },
        };
}
