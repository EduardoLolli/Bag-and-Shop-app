namespace Bag_and_Shop_app.Domain.Entities
{
    public class ItemAtribute
    {
        public int Id { get; set; }
        public int ItemId { get; set; }
        public Item Item { get; set; } = null!;

        public string Nome { get; set; } = string.Empty; // Ex: "Dano", "Defesa", "Cura"
        public string Valor { get; set; } = string.Empty; // Pode ser "1d8", "5", "+2", etc
    }
}
