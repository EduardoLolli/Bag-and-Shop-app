using Bag_and_Shop_app.Application.DTOs.User;
using Bag_and_Shop_app.Domain.Entities;
using Bag_and_Shop_app.Domain.Interfaces;

namespace Bag_and_Shop_app.Application.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }
        public Task<UserResponseDTO> AddUser(User user)
        {
            UserResponseDTO newUser = _userRepository.AddNewUser(user).Result;
            return Task.FromResult(newUser);
        }
        public Task<User?> FindUserByEmail(string email)
        {
            User? user = _userRepository.FindUserByEmail(email).Result;
            return Task.FromResult(user);
        }

        public async Task<List<UserResponseDTO>> GetAllUsers()
        {
            List<UserResponseDTO> users = await _userRepository.GetAllUsers();
            return users;
        }
    }
}
