using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace MTS_COMMON.Helper.Security
{
    public class JWTtoken
    {
        public static string GenerateJwtToken(string ID, string Username, string Email)
        {
            var issuer = "https://localhost:7127/";
            var audience = "https://localhost:7127/";

            var secretKey = "c4d623e4949b541e7a413df9d98c9b9488c919fcc97fb0f602dd0802bd0419cf";
            var keyBytes = Encoding.UTF8.GetBytes(secretKey);
            var securityKey = new SymmetricSecurityKey(keyBytes);

            var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);

            var claims = new[]
            {
                new Claim(JwtRegisteredClaimNames.Sub, ID),
                new Claim(JwtRegisteredClaimNames.UniqueName, Username),
                new Claim(JwtRegisteredClaimNames.Email, Email),
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString())
            };
            var token = new JwtSecurityToken(
                issuer: issuer,
                audience: audience,
                claims: claims,
                expires: DateTime.Now.AddMinutes(2),
                signingCredentials: credentials
            );

            return new JwtSecurityTokenHandler().WriteToken(token);
        }
    }
}
