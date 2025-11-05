using Bag_and_Shop_app.Application.DTOs.Store;
using Bag_and_Shop_app.Application.Interfaces;
using Bag_and_Shop_app.Domain.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Nelibur.ObjectMapper;

namespace Bag_and_Shop_app.Controllers
{
    [Authorize]
    [Route("api/store")]
    [ApiController]
    public class StoreController : ControllerBase
    {
        private readonly IStoreService _storeService;
        public StoreController(IStoreService storeService)
        {
            _storeService = storeService;
        }
        [HttpPost("v1/AddItemOnStore")]
        public async Task<IActionResult> AddItemOnStore([FromBody] AddItemOnStoreReqDTO dto)
        {
            try
            {
                StoreItem storeItem = TinyMapper.Map<StoreItem>(dto);



                return Ok(new
                {
                    error = false,
                    message = "Item adicionado na loja com sucesso",
                    data = storeItem
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
