using Bag_and_Shop_app.Application.DTOs.User;
using Bag_and_Shop_app.Domain.Entities;
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
        public Task<UserResponseDTO> addUser(User user)
        {
            UserResponseDTO newUser = _userRepository.addNewUser(user).Result;
            return Task.FromResult(newUser);
        }
        public Task<User> findUserByEmail(string email)
        {
            User user = _userRepository.findUserByEmail(email).Result;
            return Task.FromResult(user);
        }

        public Task<List<UserResponseDTO>> getAllUsers()
        {
            List<UserResponseDTO> users = _userRepository.getAllUsers();
            return Task.FromResult(users);
        }
    }
}
