using Bag_and_Shop_app.Application.DTOs.System;
using Bag_and_Shop_app.Application.Interfaces;
using Bag_and_Shop_app.Domain.Entities;
using Bag_and_Shop_app.Domain.Interfaces;

namespace Bag_and_Shop_app.Application.Services
{
    public class SystemService : ISystemService
    {
        private readonly ISystemRepository _systemRepository;
        public SystemService(ISystemRepository systemRepository)
        {
            _systemRepository = systemRepository;
        }
       

        public Task<SystemResponseDTO> RegisterSystem(SystemEntity newSystem)
        {
            SystemResponseDTO createdSystem = _systemRepository.AddSystem(newSystem).Result;
            return Task.FromResult(createdSystem);
        }

        public async Task<List<SystemResponseDTO>> GetAllSystems()
        {
            List<SystemResponseDTO> systems = await _systemRepository.GetSystems();

            return systems;
        }

    }
}
