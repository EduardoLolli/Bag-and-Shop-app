namespace Bag_and_Shop_app.Application.DTOs.Campaign
{
    public class CampaignResponseDTO
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public int MasterId { get; set; }
        public int PlayersLimit { get; set; }
        public int SystemId { get; set; }
        public string CampaignCode { get; set; } = string.Empty;

    }
}
