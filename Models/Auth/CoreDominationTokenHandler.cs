using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace CoreDominationBootCamp.Models.Auth
{
    public class CoreDominationTokenHandler
    {
        public TokenModel  GenerateToken(string email)
        {
           var claims = new[]
           {
               new Claim(ClaimTypes.Email, email)
           };

            var token = new TokenModel
            {
                ExpirationDate = DateTime.UtcNow.AddMinutes(30)
            };
            SymmetricSecurityKey key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("superSecretKey@345"));
            SigningCredentials creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
            JwtSecurityToken jwtToken = new JwtSecurityToken(
               issuer: "hasanalp@mail.com",
               audience: "hasanalp2@mail.com",
               claims: claims,
               expires: token.ExpirationDate,
               signingCredentials: creds
            );
            //create token
            JwtSecurityTokenHandler handler = new JwtSecurityTokenHandler();

            token.accessToken = handler.WriteToken(jwtToken);
           
            return token; 
        }
    }
}