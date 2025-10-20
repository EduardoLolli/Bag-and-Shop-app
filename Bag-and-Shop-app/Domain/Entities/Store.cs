using System.ComponentModel.DataAnnotations.Schema;

namespace Bag_and_Shop_app.Domain.Entities
{
    public class Store
    {
        public int Id { get; set; }
        public string Name { get; set; } = "Loja";
        public int CampaignId { get; set; }
        [ForeignKey(nameof(CampaignId))]
        public Campaign Campaign { get; set; } = null!;
    }
}
