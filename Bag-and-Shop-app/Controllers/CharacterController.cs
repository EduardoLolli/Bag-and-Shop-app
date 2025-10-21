using Bag_and_Shop_app.Application.DTOs.Character;
using Bag_and_Shop_app.Application.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Bag_and_Shop_app.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class CharacterController : ControllerBase
    {
        private readonly ICharacterService _characterService;
        public CharacterController(ICharacterService characterService)
        {
            _characterService = characterService;
        }

        [HttpPost("v1/createCharacter")]
        public async Task<ActionResult<CharacterCreationResponseDTO>> CreateCharacter(CharacterCreationRequestDTO dto)
        {
            try
            {
                CharacterCreationResponseDTO Character = await _characterService.CreateCharacter(dto);


                return Ok(new
                {
                    error = false,
                    message = "Personagem criado com sucesso",
                    data = Character
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
