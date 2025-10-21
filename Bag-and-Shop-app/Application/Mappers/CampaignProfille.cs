using AutoMapper;
using Bag_and_Shop_app.Application.DTOs.Character;
using Bag_and_Shop_app.Domain.Entities;

public class CampaignProfille : Profile
{
    public CampaignProfille()
    {
        CreateMap<CharacterCreationRequestDTO, Campaign>();
    }
}