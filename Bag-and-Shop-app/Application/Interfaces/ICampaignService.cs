using Bag_and_Shop_app.Application.DTOs.Campaign;
using Bag_and_Shop_app.Domain.Entities;

namespace Bag_and_Shop_app.Application.Interfaces
{
    public interface ICampaignService
    {
        Task<CampaignResponseDTO> CreateCampaign(Campaign campaign);
        Task<string> GenerateCampaignCode();

        Task<List<CampaignResponseDTO>> GetCampaignByMasterId(int masterId);
        Task<List<CampaignResponseDTO>> GetCampaignByPlayerId(int playerId);
    }
}
