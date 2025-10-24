using AutoMapper;
using Bag_and_Shop_app.Application.DTOs.Character;
using Bag_and_Shop_app.Application.DTOs.Item;
using Bag_and_Shop_app.Domain.Entities;
using Nelibur.ObjectMapper;

public class ItemProfille : Profile
{
    public ItemProfille()
    {
        TinyMapper.Bind<ItemCreationRequestDTO, Item>(config =>
        {
            config.Ignore(x => x.DiceRoll);
            config.Ignore(x => x.IconPath);
            
        });
        TinyMapper.Bind<Item, ItemCreationResponseDTO>();
    }
}