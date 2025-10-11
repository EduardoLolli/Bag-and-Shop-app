using Bag_and_Shop_app.Application.DTOs.System;
using Bag_and_Shop_app.Application.Interfaces;
using Bag_and_Shop_app.Domain.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Bag_and_Shop_app.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class SystemController : ControllerBase
    {
        private readonly ISystemService _systemService;
        public SystemController(ISystemService systemService)
        {
            _systemService = systemService;
        }

        [HttpPost("v1/SaveNewSystem")]
        public async Task<ActionResult> SaveNewSystem([FromBody] SystemRequestDTO DTO)
        {
            try
            {
                SystemEntity newSystem = new SystemEntity
                {
                    Name = DTO.Name,
                    Description = DTO.Description
                };
                SystemResponseDTO createdSystem = await _systemService.RegisterSystem(newSystem);

                return Ok(new
                {
                    error = false,
                    message = "Sistema cadastrado com sucesso",
                    data = createdSystem
                });
            }
            catch (Exception ex)
            {
                return BadRequest(new
                {
                    error = true,
                    message = ex.Message
                });
            }
        }


        [HttpGet("v1/listSystems")]
        public async Task<ActionResult> ListSystems()
        {
            try
            {
                List<SystemResponseDTO> systems = await _systemService.GetAllSystems();
                if (systems.Count < 1)
                {
                    throw new Exception("No systems found");
                }
                return Ok(new
                {
                    error = false,
                    message = "List of systems retrieved successfully",
                    data = systems
                });
            }
            catch (Exception ex)
            {
                return BadRequest(new
                {
                    error = true,
                    message = ex.Message
                });
            }
        }

    }
}
