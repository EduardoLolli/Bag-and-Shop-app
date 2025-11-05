using Nelibur.ObjectMapper;
using Bag_and_Shop_app.Application.DTOs.Store;
using Bag_and_Shop_app.Domain.Entities;

public static class TinyMapperConfig
{
    public static void RegisterBindings()
    {
        TinyMapper.Bind<AddItemOnStoreReqDTO, StoreItem>();
    }
}
