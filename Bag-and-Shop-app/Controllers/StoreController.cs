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

                storeItem = await _storeService.AddItemOnStore(storeItem);


                return Ok(new
                {
                    error = false,
                    message = "Item  adicionado na loja com sucesso",
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
        [HttpPost("v1/GetProductsByStoreID")]
        public async Task<IActionResult> GetProductsByStoreID([FromBody] StoreBaseReqDTO Store)
        {
            try
            {
                List<Item> items = await _storeService.GetItemsByStore(Store.StoreId);


                return Ok(new
                {
                    error = false,
                    message = "Itens da loja obtidos com sucesso",
                    data = items
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
        [HttpPost("v1/RemoveItemFromStore")]
        public async Task<IActionResult> RemoveItemFromStore([FromBody] AddItemOnStoreReqDTO dto)
        {
            try
            {

                


                return Ok(new
                {
                    error = false,
                    message = "Funcionalidade não implementada",
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
