using AutoMapper;
using Bag_and_Shop_app.Application.DTOs.Character;
using Bag_and_Shop_app.Domain.Entities;
using Nelibur.ObjectMapper;

public class CampaignProfille : Profile
{
    public CampaignProfille()
    {
        TinyMapper.Bind<CharacterCreationRequestDTO, Campaign>();
    }
}