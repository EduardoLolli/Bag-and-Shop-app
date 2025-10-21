using Bag_and_Shop_app.Application.DTOs.Character;
using Bag_and_Shop_app.Application.Interfaces;
using Bag_and_Shop_app.Domain.Entities;
using Bag_and_Shop_app.Domain.Interfaces;
using BagAndShopApp.Domain.Interfaces;

namespace Bag_and_Shop_app.Application.Services
{
    public class CharacterService : ICharacterService
    {
        private readonly ICharacterRepository _characterRepository;
        private readonly ICampaignRepository _campaignRepository;
        private readonly IBagRepository _bagRepository;
        private readonly IBodyRepository _bodyRepository;
        public CharacterService(
            ICharacterRepository characterRepository,
            ICampaignRepository campaignRepository,
            IBagRepository bagRepository,
            IBodyRepository bodyRepository)
        {
            _characterRepository = characterRepository;
            _campaignRepository = campaignRepository;
            _bagRepository = bagRepository;
            _bodyRepository = bodyRepository;
        }
        public async Task<CharacterCreationResponseDTO> CreateCharacter(CharacterCreationRequestDTO character)
        {
            try
            {
                var campaign = await _campaignRepository.GetCampaignByCCode(character.CampaignCode);
                Character newCharacter = new Character
                {
                    Name = character.Name,
                    UserId = character.UserId,
                    CampaignId = campaign.Id
                };
                CharacterResponseDTO newCreatedCharacter = await _characterRepository.AddCharacter(newCharacter);
                BagResponseDTO CreatedBag = await _bagRepository.CreateBagForCharacter(newCreatedCharacter.Id);
                BodyResponseDTO CreatedBody = await _bodyRepository.CreateCharacterBody(newCreatedCharacter.Id);
                
                return await Task.FromResult(new CharacterCreationResponseDTO
                {
                    Id = newCreatedCharacter.Id,
                    Name = character.Name,
                    UserId = character.UserId,
                    Campaign = campaign,
                    BagId = CreatedBag.Id,
                    Gold = CreatedBag.Gold,
                    BodyId = CreatedBody.Id

                });
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao criar personagem: " + ex.Message);
            }
        }
    }
}