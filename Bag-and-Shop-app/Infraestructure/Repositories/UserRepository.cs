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
        public Task<UserResponseDTO> AddNewUser(User user)
        {
            try
            {
                _context.Users.Add(user);
                _context.SaveChanges();
                UserResponseDTO newUser = new UserResponseDTO
                {
                    Username = user.Username,
                    Email = user.Email,
                };
                return Task.FromResult(newUser);
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao adicionar usuário: " + ex.Message);
            }
        }
        public async Task<User?> FindUserByEmail(string email)
        {
            try
            {
                return await _context.Users.FirstAsync(u => u.Email == email);
            }
            catch (Exception)
            {
                return null;
            }
        }

        public async Task<User?> FindUserById(int id)
        {
            try
            {
                return await _context.Users.FirstAsync(u => u.Id == id);
            }
            catch (Exception)
            {
                return null;
            }
        }

        public async Task<List<UserResponseDTO>> GetAllUsers()
        {
            var users = await _context.Users
                .Select(u => new UserResponseDTO
                {
                    Id = u.Id,
                    Username = u.Username,
                    Email = u.Email,
                })
                .ToListAsync();
            return users;
        }
    }
}
