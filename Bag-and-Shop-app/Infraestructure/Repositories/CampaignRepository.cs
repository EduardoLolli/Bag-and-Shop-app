using Bag_and_Shop_app.Application.DTOs.Campaign;
using Bag_and_Shop_app.Application.Interfaces;
using Bag_and_Shop_app.Domain.Entities;
using Bag_and_Shop_app.Domain.Interfaces;
using Bag_and_Shop_app.Infraestructure.Data;

namespace Bag_and_Shop_app.Infraestructure.Repositories
{
    public class CampaignRepository : ICampaignRepository
    {
        private readonly BagAndShopDBContext _bagAndShopDBContext;
        public CampaignRepository(BagAndShopDBContext bagAndShopDBContext)
        {
            _bagAndShopDBContext = bagAndShopDBContext;
        }

        public Task<CampaignResponseDTO> AddCampaign(Campaign campaign)
        {
            throw new NotImplementedException();
        }
    }
}
