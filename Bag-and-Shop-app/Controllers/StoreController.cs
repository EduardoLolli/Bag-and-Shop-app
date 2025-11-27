using Bag_and_Shop_app.Application.DTOs.Campaign;
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

        [HttpPost("v1/AddItemOnStore")]
        public async Task<IActionResult> AddItemOnStore([FromBody] ItemMovimentationDTO dto)
        {
            try
            {
                StoreItem storeItem = TinyMapper.Map<StoreItem>(dto);

                storeItem = await _storeService.AddItemOnStore(storeItem);


                ItemMovResponseDTO responseDTO = TinyMapper.Map<ItemMovResponseDTO>(storeItem);
                return Ok(new
                {
                    error = false,
                    message = "Item  adicionado na loja com sucesso",
                    data = responseDTO
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
        public async Task<ActionResult<ItemMovResponseDTO>> RemoveItemFromStore([FromBody] ItemMovimentationDTO dto)
        {
            try
            {
                StoreItem storeItem = TinyMapper.Map<StoreItem>(dto);
                storeItem = await _storeService.RemoveItemFromStore(storeItem);


                ItemMovResponseDTO responseDTO = TinyMapper.Map<ItemMovResponseDTO>(storeItem);
                return Ok(new
                {
                    error = false,
                    message = "Item/itens removido com sucesso da loja",
                    data = responseDTO
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
