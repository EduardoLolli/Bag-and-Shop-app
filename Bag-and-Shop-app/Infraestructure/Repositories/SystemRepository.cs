using Bag_and_Shop_app.Application.DTOs.System;
using Bag_and_Shop_app.Application.DTOs.User;
using Bag_and_Shop_app.Domain.Entities;
using Bag_and_Shop_app.Domain.Interfaces;
using Bag_and_Shop_app.Infraestructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Bag_and_Shop_app.Infraestructure.Repositories
{
    public class SystemRepository : ISystemRepository
    {
        private readonly BagAndShopDBContext _context;
        public SystemRepository(BagAndShopDBContext context)
        {
            _context = context;
        }

        public Task<SystemResponseDTO> AddSystem(SystemEntity system)
        {
            _context.SystemEntities.Add(system);
            _context.SaveChanges();
            SystemResponseDTO newSystem = new SystemResponseDTO
            {
                Id = system.Id,
                Name = system.Name,
                Description = system.Description,
            };
            return Task.FromResult(newSystem);
        }

        public async Task<List<SystemResponseDTO>> GetSystems()
        {
            var systems = _context.SystemEntities
                .Select(s => new SystemResponseDTO
                {
                    Id = s.Id,
                    Name = s.Name,
                    Description = s.Description,
                })
                .ToListAsync();
            return await systems;
        }

        public async Task<SystemResponseDTO?> GetSystemById(int Id)
        {
            try
            {
                var system = await _context.SystemEntities
                    .Where(s => s.Id == Id)
                    .Select(s => new SystemResponseDTO
                    {
                        Id = s.Id,
                        Name = s.Name,
                        Description = s.Description,
                    })
                    .FirstAsync();
                return system;
            } catch (Exception)
            {
                return null;
            }
        }
    }
}
