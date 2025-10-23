namespace Bag_and_Shop_app.Domain.Entities
{
    public class Campaign
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public int SystemId { get; set; }
        public int PlayersLimit { get; set; }
        public SystemEntity System { get; set; } = null!;
        public int MasterId { get; set; }
        public User Master { get; set; } = null!;
        public string CampaignCode { get; set; } = string.Empty; // Código único para a campanha
        public ICollection<Character> Characters { get; set; } = new List<Character>();
        public Store Store { get; set; } = null!;
    }
}
