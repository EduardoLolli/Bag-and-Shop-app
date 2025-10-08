using Bag_and_Shop_app.Domain.Entities;

namespace Bag_and_Shop_app.Application.Interfaces
{
    public interface IAuthService
    {

        String GenerateToken(User user);
    }
}
