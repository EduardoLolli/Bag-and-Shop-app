namespace Bag_and_Shop_app.Domain.Entities
{
    public class Character
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public int UserId { get; set; } // FK para User
        public int CampaignId { get; set; } // FK para Campaign
        public decimal Gold { get; set; } = 0m;

        public int BagId { get; set; } // FK para Bag
        public Bag Bag { get; set; } = null!;

        public int BodyId { get; set; } // FK para Body
        public Body Body { get; set; } = null!;

        public User User { get; set; } = null!;
        public Campaign Campaign { get; set; } = null!;
    }
}
