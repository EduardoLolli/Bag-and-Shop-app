using Bag_and_Shop_app.Application.DTOs.User;
using Bag_and_Shop_app.Domain.Entities;
using Bag_and_Shop_app.Domain.Interfaces;
using Bag_and_Shop_app.Infraestructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Bag_and_Shop_app.Infraestructure.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly BagAndShopDBContext _context;

        public UserRepository(BagAndShopDBContext context)
        {
                    _context = context;
        }
        public Task<UserResponseDTO> addNewUser(User user)
        {
            _context.Users.Add(user);
            _context.SaveChanges();
            UserResponseDTO newUser = new UserResponseDTO
            {
                Id = user.Id,
                Username= user.Username,
                Email = user.Email,
            };
            return Task.FromResult(newUser);
        }
        public Task<User> findUserByEmail(string email)
        {
            return _context.Users.FirstOrDefaultAsync(u => u.Email == email);
        }

        public List<UserResponseDTO> getAllUsers()
        {
            return _context.Users
                .Select(u => new UserResponseDTO
                {
                    Id = u.Id,
                    Username = u.Username,
                    Email = u.Email,
                })
                .ToList();
        }
    }
}
