using Microsoft.AspNetCore.Components.Authorization;
using System.Security.Claims;

namespace Sales.WEB.Auth
{
    public class AuthenticationProviderTest : AuthenticationStateProvider
    {
        public override async Task<AuthenticationState> GetAuthenticationStateAsync()
        {
            var anonimous = new ClaimsIdentity();
            var joseUser = new ClaimsIdentity(new List<Claim>
            {
               new Claim("FirstName", "Jose"),
               new Claim("LastName", "Guadalupe"),
               new Claim(ClaimTypes.Name, "lup_1284@hotmail.com"),
               new Claim(ClaimTypes.Role, "Admin")

             },
                authenticationType: "test");
            return await Task.FromResult(new AuthenticationState(new ClaimsPrincipal(joseUser)));
        }
    }

}
