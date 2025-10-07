using Bag_and_Shop_app.Application.DTOs.User;
namespace Bag_and_Shop_app.Application.Services
{

    public interface IUserService
    {
        Task<List<UserResponseDTO>> GetUsers();
    }
}
