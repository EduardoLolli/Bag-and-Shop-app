using System.ComponentModel.DataAnnotations;
using Bag_and_Shop_app.Domain.Enums;

namespace Bag_and_Shop_app.Application.DTOs.Item
{
    public class ItemCreationRequestDTO
    {
        [Required(ErrorMessage = "O campo nome é obrigatório")]
        public string Name { get; set; } = string.Empty;
        [Required(ErrorMessage = "O campo descrição é obrigatório")]
        public string Description { get; set; } = string.Empty;
        [Required(ErrorMessage = "O campo peso é obrigatório")]
        public decimal Weight { get; set; }
        [Required(ErrorMessage = "O campo valor é obrigatório")]
        public decimal Value { get; set; }
        [Required(ErrorMessage = "O campo tipo é obrigatório")]
        public string Type { get; set; } = string.Empty;
        [Required(ErrorMessage = "O campo raridade é obrigatório")]
        public RarityEnum Rarity { get; set; }
        public string IconPath { get; set; } = string.Empty;
        public string DiceRoll { get; set; } = null!;
        public int AttributeBonus { get; set; } = 0;
        public int AttributeDebuff { get; set; } = 0;
        public bool IsStackable { get; set; } = true;
        public int MaxStackSize { get; set; } = 20;
    }
}