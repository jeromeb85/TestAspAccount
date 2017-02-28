using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestAspAccount.Models;
using System.Security.Claims;
using Microsoft.AspNetCore.Authentication.Cookies;

namespace TestAspAccount.Data
{
    public class UserClaimsPrincipalFactory : IUserClaimsPrincipalFactory<ApplicationUser>
    {
        public Task<ClaimsPrincipal> CreateAsync(ApplicationUser user)
        {
            return Task.Factory.StartNew(() =>

            {

                if (user != null && user.Roles != null && user.Roles.Count > 0)

                {

                    // set user details in the claims

                    var claims = new List<Claim> {
                        new Claim(ClaimTypes.NameIdentifier, user.Id),
                     //   new Claim(ClaimTypes.Name, user.DisplayName),
                        new Claim(ClaimTypes.Email, user.Email),
                      //  new Claim(ClaimTypes.GivenName, user.FirstName),

                       // new Claim(ClaimTypes.Surname, user.LastName),

                    };



                    // set user roles in the claims

                    foreach (var role in user.Roles)
                    {                    
                        claims.Add(new Claim(ClaimTypes.Role, role));
                    }



                    var identity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                    var principle = new ClaimsPrincipal(identity);

                    return principle;

                }

                else

                    return new ClaimsPrincipal();

            });
        }
    }
}
