
using Domain.Enums;
using Microsoft.AspNetCore.DataProtection.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;

namespace WEBAPI.Middleware
{
    public class RoleCheck : Attribute, IAuthorizationFilter
    {
        private readonly Roles _role;

        public RoleCheck(Roles role)
        {
            _role = role;
        }

        public void OnAuthorization(AuthorizationFilterContext context)
        {
            var token = context.HttpContext.Request.Headers["Authorization"].FirstOrDefault()?.Split(" ").Last();

            if (token != null)
            {
                var username = GetUsernameFromToken(token); // Implement this method to extract the username

                if (username == null) context.Result = new UnauthorizedResult(); // Return 401 Unauthorized if username is null

                //List<Roles> roles = context.HttpContext.RequestServices.GetService<IUserRepo>().GetRoleByUsername(username);
                List<Roles> roles = new List<Roles> { Roles.Editor }; // Mocked roles

                if (roles == null || !roles.Contains(_role))
                {
                    context.Result = new ForbidResult(); // Return 403 Forbidden
                    return;
                }
            }
            else
            {
                context.Result = new UnauthorizedResult(); // Return 401 Unauthorized if token is missing
            }
        }

        private string? GetUsernameFromToken(string token)
        {
            var tokenHandler = new JwtSecurityTokenHandler();
            var jwtToken = tokenHandler.ReadJwtToken(token);

            // Extract the username from the claims
            var usernameClaim = jwtToken.Claims.FirstOrDefault(c => c.Type == ClaimTypes.Name);

            return usernameClaim?.Value;
        }
    }
}
