using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Project12_JwtToken.Jwt
{
    public class tokenValidator
    {
        public ClaimsPrincipal ValidateJwtToken(string token)
        {
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.UTF8.GetBytes("20Derste20ProjeToken+-*/1234TokenJwt");
            try
            {
                var principal = tokenHandler.ValidateToken(token, new TokenValidationParameters
                {
                    ValidateIssuerSigningKey = true,
                    IssuerSigningKey = new SymmetricSecurityKey(key),
                    ValidateIssuer = true,
                    ValidIssuer = "LocalHost",
                    ValidateAudience = true,
                    ValidAudience = "LocalHost",
                    ValidateLifetime= true,
                    ClockSkew = TimeSpan.Zero
                },out SecurityToken validatedToken);
                return principal;
            }

            catch (Exception)
            {
                return null;
            }


        }   
    }
}
