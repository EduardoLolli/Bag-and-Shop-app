using Bag_and_Shop_app.Application.DTOs.Store;
using Bag_and_Shop_app.Domain.Entities;
using Nelibur.ObjectMapper;

namespace Bag_and_Shop_app.Application.Mappers
{
    public class StoreItemProfille
    {
        public StoreItemProfille()
        {
            TinyMapper.Bind<AddItemOnStoreReqDTO, StoreItem>(config =>
            {
                config.Bind(source => source.ItemId, target => target.ItemId);
                config.Bind(source => source.StoreId, target => target.StoreId);
                config.Bind(source => source.Price, target => target.Price);
                config.Bind(source => source.Quantity, target => target.Quantity);
            });
        }
    }
}
