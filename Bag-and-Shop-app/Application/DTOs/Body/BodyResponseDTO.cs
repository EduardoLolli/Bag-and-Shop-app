using System.ComponentModel.DataAnnotations;

namespace Bag_and_Shop_app.Application.DTOs.Character
{

    public class BodyResponseDTO
    {
        public int Id { get; set; }
        public int CharacterId { get; set; }
        public int WeaponId { get; set; }
        public int ArmorId { get; set; }
        public int ShieldId { get; set; }
        public int BootsId { get; set; }
        public int GlovesId { get; set; }
        public int AmuletId { get; set; }
        public int RingId { get; set; }
    }
}