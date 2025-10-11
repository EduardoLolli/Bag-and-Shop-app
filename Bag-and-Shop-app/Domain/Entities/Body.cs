namespace Bag_and_Shop_app.Domain.Entities
{
    public class Body
    {
        public int Id { get; set; }
        public int CharacterId { get; set; }
        public int? WeaponId { get; set; }
        public int? ArmorId { get; set; }
        public int? ShieldId { get; set; }
        public int? BootsId { get; set; }
        public int? GlovesId { get; set; }
        public int? AmuletId { get; set; }
        public int? RingId { get; set; }


        public Item? Weapon { get; set; }
        public Item? Armor { get; set; }
        public Item? Shield { get; set; }
        public Item? Boots { get; set; }
        public Item? Gloves { get; set; }
        public Item? Amulet { get; set; }
        public Item? Ring { get; set; }
    }
}
