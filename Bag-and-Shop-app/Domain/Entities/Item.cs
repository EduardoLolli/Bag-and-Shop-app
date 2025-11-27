using Bag_and_Shop_app.Domain.Enums;

namespace Bag_and_Shop_app.Domain.Entities
{
    public class Item
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public Double Weight { get; set; }
        public Double Value { get; set; }
        public TypeEnum Type { get; set; } 
        public RarityEnum Rarity { get; set; }
        public string IconPath { get; set; } = string.Empty;
        public string DiceRoll { get; set; } = string.Empty;
        public int AttributeBonus { get; set; }
        public int AttributeDebuff { get; set; }
        public bool IsStackable { get; set; }
        public int MaxStackSize { get; set; }

    }
}
