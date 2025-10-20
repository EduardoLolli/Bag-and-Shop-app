using System.ComponentModel.DataAnnotations.Schema;

namespace Bag_and_Shop_app.Domain.Entities
{
    public class Body
    {
        public int Id { get; set; }
        public int CharacterId { get; set; }
        [ForeignKey(nameof(CharacterId))]
        public Character? Character { get; set; }
        public int? WeaponId { get; set; }
        [ForeignKey(nameof(WeaponId))]
        public Item? Weapon { get; set; }
        public int? ArmorId { get; set; }
        [ForeignKey(nameof(ArmorId))]
        public Item? Armor { get; set; }
        public int? ShieldId { get; set; }
        [ForeignKey(nameof(ShieldId))]
        public Item? Shield { get; set; }
        public int? BootsId { get; set; }
        [ForeignKey(nameof(BootsId))]
        public Item? Boots { get; set; }
        public int? GlovesId { get; set; }
        [ForeignKey(nameof(GlovesId))]
        public Item? Gloves { get; set; }
        public int? AmuletId { get; set; }
        [ForeignKey(nameof(AmuletId))]
        public Item? Amulet { get; set; }
        public int? RingId { get; set; }
        [ForeignKey(nameof(RingId))]
        public Item? Ring { get; set; }


    }
}
