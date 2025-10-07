using Bag_and_Shop_app.Application.DTOs.User;
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

        public async Task<List<UserResponseDTO>> GetAllUsers()
        {
            return await _context.Users.Select(user => new UserResponseDTO
            {
                Id = user.Id,
                Username = user.Username,
                Email = user.Email
            }).ToListAsync();
        }

    }
}
