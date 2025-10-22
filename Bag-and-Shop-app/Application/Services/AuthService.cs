using Bag_and_Shop_app.Application.DTOs.Auth;
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

            return _hasher.HashPassword(string.Empty, password);
        }

        public Boolean VerifyPass(string hashedPassword, string providedPassword)
        {
            var result = _hasher.VerifyHashedPassword(string.Empty, hashedPassword, providedPassword);
            return result == PasswordVerificationResult.Success;
        }

        public string GenerateToken(User user)
        {
            var key = Encoding.ASCII.GetBytes(Bag_and_Shop_app.Key.secret);
            var tokenConfig = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new[]
                {
                    new Claim("UserId", user.Id.ToString()),
                    new Claim("UserName", user.Username),
                    new Claim("Email", user.Email),
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

        public async Task<User> ValidateToken(AuthRequestDTO token)
        {
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(Bag_and_Shop_app.Key.secret);
            try
            {
                tokenHandler.ValidateToken(token.Token, new TokenValidationParameters
                {
                    ValidateIssuerSigningKey = true,
                    IssuerSigningKey = new SymmetricSecurityKey(key),
                    ValidateIssuer = false,
                    ValidateAudience = false,
                    ClockSkew = TimeSpan.Zero
                }, out SecurityToken validatedToken);
                var jwtToken = (JwtSecurityToken)validatedToken;
                return new User
                {
                    Id = int.Parse(jwtToken.Claims.First(x => x.Type == "UserId").Value),
                    Username = jwtToken.Claims.First(x => x.Type == "UserName").Value,
                    Email = jwtToken.Claims.First(x => x.Type == "Email").Value,
                    Role = jwtToken.Claims.First(x => x.Type == "UserRole").Value
                };

            }
            catch
            {
                return null!;
            }
        }
    }
}
