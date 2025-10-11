using Bag_and_Shop_app.Application.DTOs.Campaign;
using Bag_and_Shop_app.Application.Interfaces;
using Bag_and_Shop_app.Domain.Entities;
using Bag_and_Shop_app.Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Bag_and_Shop_app.Application.Services
{

    public class CampaignService : ICampaignService
    {
        private readonly ICampaignRepository _campaignRepository;
        public CampaignService(ICampaignRepository campaignRepository)
        {
            _campaignRepository = campaignRepository;
        }

        public async Task<CampaignResponseDTO> CreateCampaign(Campaign campaign)
        {
            CampaignResponseDTO createdCampaign = await _campaignRepository.AddCampaign(campaign);

            return createdCampaign;


        }
    }
}
