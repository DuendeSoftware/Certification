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
                ClientId = "implicit1",
                AllowedGrantTypes = GrantTypes.Implicit,
                RequirePkce = false,
                AllowAccessTokensViaBrowser = true,

                RedirectUris = { "https://www.certification.openid.net/test/a/duende-op/callback" },
                PostLogoutRedirectUris = { "https://www.certification.openid.net/test/a/duende-op/post_logout_redirect" },

                AllowedScopes = { "openid", "profile", "email", "phone", "address" }
            },
            
            new Client
            {
                ClientId = "implicit1front",
                AllowedGrantTypes = GrantTypes.Implicit,
                RequirePkce = false,
                AllowAccessTokensViaBrowser = true,

                RedirectUris = { "https://www.certification.openid.net/test/a/duende-op/callback" },
                PostLogoutRedirectUris = { "https://www.certification.openid.net/test/a/duende-op/post_logout_redirect" },

                FrontChannelLogoutUri = "https://www.certification.openid.net/test/a/duende-op/frontchannel_logout",
                FrontChannelLogoutSessionRequired = true,

                AllowedScopes = { "openid", "profile", "email", "phone", "address" }
            },
            
            new Client
            {
                ClientId = "implicit1back",
                AllowedGrantTypes = GrantTypes.Implicit,
                RequirePkce = false,
                AllowAccessTokensViaBrowser = true,

                RedirectUris = { "https://www.certification.openid.net/test/a/duende-op/callback" },
                PostLogoutRedirectUris = { "https://www.certification.openid.net/test/a/duende-op/post_logout_redirect" },
                
                BackChannelLogoutUri = "https://www.certification.openid.net/test/a/duende-op/backchannel_logout",
                BackChannelLogoutSessionRequired = true,

                AllowedScopes = { "openid", "profile", "email", "phone", "address" }
            },
            
            new Client
            {
                ClientId = "implicit2",
                AllowedGrantTypes = GrantTypes.Implicit,
                RequirePkce = false,
                AllowAccessTokensViaBrowser = true,

                RedirectUris = { "https://www.certification.openid.net/test/a/duende-op/callback" },
                PostLogoutRedirectUris = { "https://www.certification.openid.net/test/a/duende-op/post_logout_redirect" },

                FrontChannelLogoutUri = "https://www.certification.openid.net/test/a/duende-op/frontchannel_logout",
                FrontChannelLogoutSessionRequired = true,

                BackChannelLogoutUri = "https://www.certification.openid.net/test/a/duende-op/backchannel_logout",
                BackChannelLogoutSessionRequired = true,

                AllowedScopes = { "openid", "profile", "email", "phone", "address" }
            },

            new Client
            {
                ClientId = "code1",
                ClientSecrets =
                {
                    new Secret("9u30jjd8dj83jh98jdj898j8jsd89j983hh8ddh".ToSha256())
                },

                AllowedGrantTypes = GrantTypes.Code,
                RequirePkce = false,

                RedirectUris = { "https://www.certification.openid.net/test/a/duende-op/callback" },
                PostLogoutRedirectUris = { "https://www.certification.openid.net/test/a/duende-op/post_logout_redirect" },

                AllowOfflineAccess = true,
                AllowedScopes = { "openid", "profile", "email", "phone", "address" }
            },
            
            new Client
            {
                ClientId = "code1front",
                ClientSecrets =
                {
                    new Secret("9u30jjd8dj83jh98jdj898j8jsd89j983hh8ddh".ToSha256())
                },

                AllowedGrantTypes = GrantTypes.Code,
                RequirePkce = false,

                RedirectUris = { "https://www.certification.openid.net/test/a/duende-op/callback" },
                PostLogoutRedirectUris = { "https://www.certification.openid.net/test/a/duende-op/post_logout_redirect" },

                FrontChannelLogoutUri = "https://www.certification.openid.net/test/a/duende-op/frontchannel_logout",
                FrontChannelLogoutSessionRequired = true,
                
                AllowOfflineAccess = true,
                AllowedScopes = { "openid", "profile", "email", "phone", "address" }
            },

            new Client
            {
                ClientId = "code1back",
                ClientSecrets =
                {
                    new Secret("9u30jjd8dj83jh98jdj898j8jsd89j983hh8ddh".ToSha256())
                },

                AllowedGrantTypes = GrantTypes.Code,
                RequirePkce = false,

                RedirectUris = { "https://www.certification.openid.net/test/a/duende-op/callback" },
                PostLogoutRedirectUris = { "https://www.certification.openid.net/test/a/duende-op/post_logout_redirect" },

                BackChannelLogoutUri = "https://www.certification.openid.net/test/a/duende-op/backchannel_logout",
                BackChannelLogoutSessionRequired = true,

                AllowOfflineAccess = true,
                AllowedScopes = { "openid", "profile", "email", "phone", "address" }
            },
            
            new Client
            {
                ClientId = "code2",
                ClientSecrets =
                {
                    new Secret("9u30jjd8dj83jh98jdj898j8jsd89j983hh8ddh".ToSha256())
                },

                AllowedGrantTypes = GrantTypes.Code,
                RequirePkce = false,

                RedirectUris = { "https://www.certification.openid.net/test/a/duende-op/callback" },
                PostLogoutRedirectUris = { "https://www.certification.openid.net/test/a/duende-op/post_logout_redirect" },

                FrontChannelLogoutUri = "https://www.certification.openid.net/test/a/duende-op/frontchannel_logout",
                FrontChannelLogoutSessionRequired = true,

                BackChannelLogoutUri = "https://www.certification.openid.net/test/a/duende-op/backchannel_logout",
                BackChannelLogoutSessionRequired = true,

                AllowOfflineAccess = true,
                AllowedScopes = { "openid", "profile", "email", "phone", "address" }
            },
            
            new Client
            {
                ClientId = "hybrid1",
                ClientSecrets =
                {
                    new Secret("9u30jjd8dj83jh98jdj898j8jsd89j983hh8ddh".ToSha256())
                },

                AllowedGrantTypes = GrantTypes.Hybrid,
                RequirePkce = false,
                AllowAccessTokensViaBrowser = true,

                RedirectUris = { "https://www.certification.openid.net/test/a/duende-op/callback" },
                PostLogoutRedirectUris = { "https://www.certification.openid.net/test/a/duende-op/post_logout_redirect" },
                
                AllowOfflineAccess = true,
                AllowedScopes = { "openid", "profile", "email", "phone", "address" }
            },
            
            new Client
            {
                ClientId = "hybrid1front",
                ClientSecrets =
                {
                    new Secret("9u30jjd8dj83jh98jdj898j8jsd89j983hh8ddh".ToSha256())
                },

                AllowedGrantTypes = GrantTypes.Hybrid,
                RequirePkce = false,
                AllowAccessTokensViaBrowser = true,

                RedirectUris = { "https://www.certification.openid.net/test/a/duende-op/callback" },
                PostLogoutRedirectUris = { "https://www.certification.openid.net/test/a/duende-op/post_logout_redirect" },

                FrontChannelLogoutUri = "https://www.certification.openid.net/test/a/duende-op/frontchannel_logout",
                FrontChannelLogoutSessionRequired = true,

                AllowOfflineAccess = true,
                AllowedScopes = { "openid", "profile", "email", "phone", "address" }
            },
            
            new Client
            {
                ClientId = "hybrid1back",
                ClientSecrets =
                {
                    new Secret("9u30jjd8dj83jh98jdj898j8jsd89j983hh8ddh".ToSha256())
                },

                AllowedGrantTypes = GrantTypes.Hybrid,
                RequirePkce = false,
                AllowAccessTokensViaBrowser = true,

                RedirectUris = { "https://www.certification.openid.net/test/a/duende-op/callback" },
                PostLogoutRedirectUris = { "https://www.certification.openid.net/test/a/duende-op/post_logout_redirect" },

                BackChannelLogoutUri = "https://www.certification.openid.net/test/a/duende-op/backchannel_logout",
                BackChannelLogoutSessionRequired = true,

                AllowOfflineAccess = true,
                AllowedScopes = { "openid", "profile", "email", "phone", "address" }
            },
            
           
            new Client
            {
                ClientId = "hybrid2",
                ClientSecrets =
                {
                    new Secret("9u30jjd8dj83jh98jdj898j8jsd89j983hh8ddh".ToSha256())
                },

                AllowedGrantTypes = GrantTypes.Hybrid,
                RequirePkce = false,
                AllowAccessTokensViaBrowser = true,

                RedirectUris = { "https://www.certification.openid.net/test/a/duende-op/callback" },
                PostLogoutRedirectUris = { "https://www.certification.openid.net/test/a/duende-op/post_logout_redirect" },

                FrontChannelLogoutUri = "https://www.certification.openid.net/test/a/duende-op/frontchannel_logout",
                FrontChannelLogoutSessionRequired = true,

                BackChannelLogoutUri = "https://www.certification.openid.net/test/a/duende-op/backchannel_logout",
                BackChannelLogoutSessionRequired = true,

                AllowOfflineAccess = true,
                AllowedScopes = { "openid", "profile", "email", "phone", "address" }
            }
        };
}
