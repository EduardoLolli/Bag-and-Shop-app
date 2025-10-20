namespace Bag_and_Shop_app.Domain.Entities
{
    public class Item
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public decimal Weight { get; set; }
        public decimal Value { get; set; }
        public string Type { get; set; } = string.Empty; // arma, armadura, consumível, etc.
        public string Rarity { get; set; } = string.Empty; // comum, raro, épico, lendário, etc.
        public string IconPath { get; set; } = string.Empty; // caminho para o ícone do item
        public string DiceRoll { get; set; } = string.Empty; // Ex: "1d6", "2d8+3", etc.
        public int AttributeBonus { get; set; } // Ex: +2, +3, etc.
        public int AttributeDebuff { get; set; } // Ex: -1, -2, etc.
        public bool IsStackable { get; set; }
        public int MaxStackSize { get; set; }
        public ICollection<BagItem> BagItems { get; set; } = new List<BagItem>();

    }
}
