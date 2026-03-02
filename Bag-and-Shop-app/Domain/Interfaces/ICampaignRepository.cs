using Bag_and_Shop_app.Application.DTOs.Campaign;
using Bag_and_Shop_app.Domain.Entities;

namespace Bag_and_Shop_app.Domain.Interfaces
{
    public interface ICampaignRepository
    {
        Task<CampaignResponseDTO> AddCampaign(Campaign campaign);
        Task<Boolean> VerifyCode(string code);
        Task<List<CampaignResponseDTO>> GetCampaignByMasterId(int masterId);
        Task<CampaignResponseDTO> GetCampaignByCCode(string campaignCode);
    }
}
