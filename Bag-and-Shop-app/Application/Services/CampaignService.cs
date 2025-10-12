using Bag_and_Shop_app.Application.DTOs.Campaign;
using Bag_and_Shop_app.Application.Interfaces;
using Bag_and_Shop_app.Domain.Entities;
using Bag_and_Shop_app.Domain.Interfaces;
using Bag_and_Shop_app.Infraestructure.Data;
using Bag_and_Shop_app.Infraestructure.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace Bag_and_Shop_app.Application.Services
{

    public class CampaignService : ICampaignService
    {
        private readonly ICampaignRepository _campaignRepository;
        private readonly IStoreRepository _storeRepository;
        private readonly IStoreItemRepository _storeItemRepository;
        public CampaignService(ICampaignRepository campaignRepository, IStoreRepository storeRepository)
        {
            _campaignRepository = campaignRepository;
            _storeRepository = storeRepository;
        }

        public async Task<CampaignResponseDTO> CreateCampaign(Campaign campaign)
        {
            CampaignResponseDTO createdCampaign = await _campaignRepository.AddCampaign(campaign);
            Store store = new Store
            {
                Name = "Loja",
                CampaignId = createdCampaign.Id
            };

            Store storeCreated = await _storeRepository.AddStore(store);
            Boolean storeItemCreated = await _storeItemRepository.AddStoreItem(new StoreItem
            {
                StoreId = storeCreated.Id
            });

            return createdCampaign;


        }
    }
}
