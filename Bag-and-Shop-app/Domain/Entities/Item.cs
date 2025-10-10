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
        public string Status { get; set; } = "Disponível"; // Conservado, Desgastado, etc.

        public int? LojaId { get; set; }
        public Store? Store { get; set; }

        public int? BagId { get; set; }
        public Bag? Bag { get; set; }
    }
}
