using AutoMapper;
using Bag_and_Shop_app.Application.DTOs.Item;
using Bag_and_Shop_app.Application.Interfaces;
using Bag_and_Shop_app.Domain.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.WebEncoders.Testing;

namespace Bag_and_Shop_app.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Authorize]
    public class ItemController : ControllerBase
    {
        private readonly IItemService _itemService;
        private readonly IMapper _mapper;
        public ItemController(IItemService itemService, IMapper mapper)
        {
            _itemService = itemService;
            _mapper = mapper;
        }


        [HttpPost("v1/createItem")]
        public async Task<ActionResult<ItemCreationResponseDTO>> CreateNewItem([FromBody] ItemCreationRequestDTO dto)
        {
            Item item = _mapper.Map<Item>(dto);
            ItemCreationResponseDTO response = await _itemService.CreateItem(item);
            return Ok(
                new
                {
                    error = false,
                    message = "Item criado com sucesso",
                    data = response
                });
        }



    }
}
