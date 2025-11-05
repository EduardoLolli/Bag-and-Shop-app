using AutoMapper;
using Bag_and_Shop_app.Application.DTOs.Item;
using Bag_and_Shop_app.Application.Interfaces;
using Bag_and_Shop_app.Domain.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.WebEncoders.Testing;
using Nelibur.ObjectMapper;

namespace Bag_and_Shop_app.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Authorize]
    public class ItemController : ControllerBase
    {
        private readonly IItemService _itemService;
        public ItemController(IItemService itemService)
        {
            _itemService = itemService;
        }


        [HttpPost("v1/createItem")]
        public async Task<ActionResult<ItemCreationResponseDTO>> CreateNewItem([FromBody] ItemCreationRequestDTO itemDto)
        {

            Item item = TinyMapper.Map<Item>(itemDto);
            ItemCreationResponseDTO response = await _itemService.CreateItem(item);
            return Ok(
                new
                {
                    error = false,
                    message = "Item criado com sucesso",
                    data = response
                });
        }

        [HttpPost("v1/createItems")]
        public async Task<ActionResult<ItemCreationResponseDTO>> CreateNewItems([FromBody] List<ItemCreationRequestDTO> itemDto)
        {

            var responses = new List<ItemCreationResponseDTO>();
            foreach (var dto in itemDto)
            {
                Item item = TinyMapper.Map<Item>(dto);
                ItemCreationResponseDTO resp = await _itemService.CreateItem(item);
                responses.Add(resp);
            }

            return Ok(new
            {
                error = false,
                message = "Itens criados com sucesso",
                data = responses
            });
        }



    }
}
