using Bag_and_Shop_app.Application.DTOs.Campaign;
using Bag_and_Shop_app.Domain.Entities;

namespace Bag_and_Shop_app.Domain.Interfaces
{
    public interface ICampaignRepository
    {
        Task<CreateCampaignResponseDTO> AddCampaign(Campaign campaign);
        Task<Boolean> VerifyCode(string code);
        Task<List<CreateCampaignResponseDTO>> GetCampaignByMasterId(int masterId);
        Task<CreateCampaignResponseDTO> GetCampaignByCCode(string campaignCode);
    }
}
