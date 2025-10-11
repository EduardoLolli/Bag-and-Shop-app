namespace Bag_and_Shop_app.Domain.Entities
{
    public class BagItem
    {
        public int Id { get; set; }
        public int BagId { get; set; }
        public Bag Bag { get; set; } = null!;

        public int ItemId { get; set; }
        public Item Item { get; set; } = null!;

        public int Quantidade { get; set; }
        public double Condicao { get; set; } // Ex: 100%, 80%, etc
    }
}
