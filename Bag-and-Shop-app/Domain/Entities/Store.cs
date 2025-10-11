namespace Bag_and_Shop_app.Domain.Entities
{
    public class Store
    {
        public int Id { get; set; }
        public string Name { get; set; } = "Loja Padrão";
        public int CampaignId { get; set; } // FK para Campaign
        public ICollection<StoreItem> Items { get; set; } = new List<StoreItem>();
    }
}
