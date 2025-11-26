using Bag_and_Shop_app.Application.DTOs.Campaign;
using Bag_and_Shop_app.Domain.Entities;
using Bag_and_Shop_app.Domain.Interfaces;
using Bag_and_Shop_app.Infraestructure.Data;
using Microsoft.EntityFrameworkCore;

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
            try
            {
                _bagAndShopDBContext.Campaigns.Add(campaign);
                _bagAndShopDBContext.SaveChanges();
                CampaignResponseDTO campaignResponseDTO = new CampaignResponseDTO
                {
                    Id = campaign.Id,
                    Name = campaign.Name,
                    MasterId = campaign.MasterId,
                    PlayersLimit = campaign.PlayersLimit,
                    SystemId = campaign.SystemId,
                    CampaignCode = campaign.CampaignCode
                };
                return Task.FromResult(campaignResponseDTO);
            }
            catch (Exception e)
            {
                throw new Exception("Falha ao criar a campanha.");
            }
        }

        public async Task<CampaignResponseDTO> GetCampaignByCCode(string campaignCode)
        {
            try
            {
                return await _bagAndShopDBContext.Campaigns
                .Where(c => c.CampaignCode == campaignCode)
                .Select(c => new CampaignResponseDTO
                {
                    Id = c.Id,
                    Name = c.Name,
                    PlayersLimit = c.PlayersLimit,
                    MasterId = c.MasterId,
                    SystemId = c.SystemId,
                    CampaignCode = c.CampaignCode
                })
                .FirstAsync();
            }
            catch (Exception)
            {
                throw new Exception("Campanha não encontrada");
            }
        }

        public Task<List<CampaignResponseDTO>> GetCampaignByMasterId(int masterId)
        {
            var campaigns = _bagAndShopDBContext.Campaigns
                .Where(c => c.MasterId == masterId)
                .Select(c => new CampaignResponseDTO
                {
                    Id = c.Id,
                    Name = c.Name,
                    PlayersLimit = c.PlayersLimit,
                    MasterId = c.MasterId,
                    SystemId = c.SystemId,
                    CampaignCode = c.CampaignCode
                })
                .ToListAsync();

            return campaigns;
        }

        public Task<Boolean> VerifyCode(string code)
        {
            var result = _bagAndShopDBContext.Campaigns.FirstOrDefaultAsync(c => c.CampaignCode == code);

            if (result.Result == null)
            {
                return Task.FromResult(false);
            }
            return Task.FromResult(true);
        }
    }
}
