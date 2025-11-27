using Bag_and_Shop_app.Application.DTOs.Campaign;
using Bag_and_Shop_app.Application.DTOs.Item;
using Bag_and_Shop_app.Application.DTOs.Store;
using Bag_and_Shop_app.Domain.Entities;
using Nelibur.ObjectMapper;

public static class TinyMapperConfig
{
    public static void RegisterBindings()
    {
        TinyMapper.Bind<ItemMovimentationDTO, StoreItem>();
        TinyMapper.Bind<ItemCreationRequestDTO, Item>();
        TinyMapper.Bind<Item, ItemCreationResponseDTO>();
        TinyMapper.Bind<Campaign, CampaignResponseDTO>();
        TinyMapper.Bind<CampaignRequestDTO, Campaign>();
        TinyMapper.Bind<StoreItem, ItemMovResponseDTO>();
    }
}
