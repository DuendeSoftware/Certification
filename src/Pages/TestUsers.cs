// Copyright (c) Duende Software. All rights reserved.
// See LICENSE in the project root for license information.


using IdentityModel;
using System.Security.Claims;
using System.Text.Json;
using Duende.IdentityServer;
using Duende.IdentityServer.Test;

namespace Certification;

public class TestUsers
{
    public static List<TestUser> Users
    {
        get
        {
            var address = new
            {
                street_address = "One Hacker Way",
                locality = "Heidelberg",
                postal_code = "69118",
                country = "Germany"
            };
                
            return new List<TestUser>
            {
                new TestUser
                {
                    SubjectId = "1",
                    Username = "alice",
                    Password = "alice",
                    Claims =
                    {
                        new Claim(JwtClaimTypes.Name, "Alice Smith"),
                        new Claim(JwtClaimTypes.GivenName, "Alice"),
                        new Claim(JwtClaimTypes.FamilyName, "Smith"),
                        
                        new Claim(JwtClaimTypes.Email, "AliceSmith@email.com"),
                        new Claim(JwtClaimTypes.EmailVerified, "true", ClaimValueTypes.Boolean),
                        new Claim(JwtClaimTypes.WebSite, "https://alice.com"),
                        new Claim(JwtClaimTypes.PhoneNumber, "123"),
                        new Claim(JwtClaimTypes.PhoneNumberVerified, "true", ClaimValueTypes.Boolean),
                        new Claim(JwtClaimTypes.Address, JsonSerializer.Serialize(address), IdentityServerConstants.ClaimValueTypes.Json),
                        
                        // for completeness
                        new Claim(JwtClaimTypes.ZoneInfo, "Europe/Paris"),
                        new Claim(JwtClaimTypes.BirthDate, "1973-11-12"),
                        new Claim(JwtClaimTypes.Gender, "female"),
                        new Claim(JwtClaimTypes.Profile, "https://duendesoftware.com/alice"),
                        new Claim(JwtClaimTypes.PreferredUserName, "alice"),
                        new Claim(JwtClaimTypes.MiddleName, "Mary"),
                        new Claim(JwtClaimTypes.NickName, "A"),
                        new Claim(JwtClaimTypes.Locale, "fr-CA"),
                        new Claim(JwtClaimTypes.Picture, "https://duendesoftware.com/alice/picture"),
                        new Claim(JwtClaimTypes.UpdatedAt, "1693317283", ClaimValueTypes.Integer),
                    }
                }
            };
        }
    }
}