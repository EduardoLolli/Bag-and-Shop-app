using Bag_and_Shop_app.Application.DTOs.System;
using Bag_and_Shop_app.Domain.Entities;

namespace Bag_and_Shop_app.Application.Interfaces
{
    public interface ISystemService
    {
        Task<SystemResponseDTO> RegisterSystem(SystemEntity newSystem);
        Task<List<SystemResponseDTO>> GetAllSystems();
    }
}
