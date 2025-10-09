using Bag_and_Shop_app.Application.Interfaces;
using Bag_and_Shop_app.Domain.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace Bag_and_Shop_app.Application.Services
{
    public class AuthService : IAuthService
    {
        private readonly PasswordHasher<string> _hasher = new();

        public string HashPass(string password)
        {
            if (string.IsNullOrEmpty(password))
                throw new ArgumentException("Password não pode ser nulo ou vazio.", nameof(password));

            return _hasher.HashPassword(null, password);
        }

        public Boolean VerifyPass(string hashedPassword, string providedPassword)
        {
            var result = _hasher.VerifyHashedPassword(null, hashedPassword, providedPassword);
            return result == PasswordVerificationResult.Success;
        }

        public string GenerateToken(User user)
        {
            var key = Encoding.ASCII.GetBytes(Bag_and_Shop_app.key.secret);
            var tokenConfig = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new[]
                {
                    new Claim("UserId", user.Id.ToString()),
                    new Claim("UserName", user.Username),
                    new Claim("UserRole", user.Role)
                }),
                Expires = DateTime.UtcNow.AddHours(24),
                SigningCredentials = new SigningCredentials(
                    new SymmetricSecurityKey(key),
                    SecurityAlgorithms.HmacSha256Signature)
            };

            var tokenHandler = new JwtSecurityTokenHandler();
            var token = tokenHandler.CreateToken(tokenConfig);
            return tokenHandler.WriteToken(token);
        }
    }
}
