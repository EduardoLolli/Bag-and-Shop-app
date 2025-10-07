using Bag_and_Shop_app.Application.DTOs.User;
using Bag_and_Shop_app.Domain.Interfaces;
using System.Collections.Generic;

namespace Bag_and_Shop_app.Application.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }
        public async Task<List<UserResponseDTO>> GetUsers()
        {
            List<UserResponseDTO> users = await _userRepository.GetAllUsers();
            return users;
        }

    }
}
