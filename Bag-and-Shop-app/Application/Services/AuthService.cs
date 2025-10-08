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
        public string HashPass(string password)
        {
            if (string.IsNullOrEmpty(password))
                throw new ArgumentException("Password não pode ser nulo ou vazio.", nameof(password));

            var hasher = new PasswordHasher<string>();
            return hasher.HashPassword(null, password);
        }

        string IAuthService.GenerateToken(User user)
        {
            var key = Encoding.ASCII.GetBytes(Bag_and_Shop_app.key.secret);
            var tokenConfig = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new Claim[]
                            {
                                new Claim("UserId", user.Id.ToString()),
                                new Claim("UserName", user.Username.ToString()),
                                new Claim("UserRole", user.Role.ToString())
                            }),
                Expires = DateTime.UtcNow.AddHours(24),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };
            var tokenHandler = new JwtSecurityTokenHandler();
            var token = tokenHandler.CreateToken(tokenConfig);
            var tokenString = tokenHandler.WriteToken(token);

            return tokenString;
        }


    }
}
