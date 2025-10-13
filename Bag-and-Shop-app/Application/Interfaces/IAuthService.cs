using Bag_and_Shop_app.Application.DTOs.Auth;
using Bag_and_Shop_app.Domain.Entities;

namespace Bag_and_Shop_app.Application.Interfaces
{
    public interface IAuthService
    {

        String GenerateToken(User user);
        String HashPass(String password);
        User ValidateToken(AuthRequestDTO token);
        Boolean VerifyPass(string passwordHash, string password);
    }
}
