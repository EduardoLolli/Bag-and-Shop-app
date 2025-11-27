using Bag_and_Shop_app.Application.DTOs.System;
using Bag_and_Shop_app.Domain.Entities;

namespace Bag_and_Shop_app.Domain.Interfaces
{
    public interface ISystemRepository
    {
        Task<SystemResponseDTO> AddSystem(SystemEntity system); 
        Task<List<SystemResponseDTO>> GetSystems();
        Task<SystemResponseDTO?> GetSystemById(int Id);
    }
}
