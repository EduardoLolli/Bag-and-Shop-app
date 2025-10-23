using AutoMapper;
using Bag_and_Shop_app.Application.DTOs.Character;
using Bag_and_Shop_app.Application.DTOs.Item;
using Bag_and_Shop_app.Domain.Entities;

public class ItemProfille : Profile
{
    public ItemProfille()
    {
        CreateMap<ItemCreationRequestDTO, Item>();
        CreateMap<Item, ItemCreationResponseDTO>();
    }
}