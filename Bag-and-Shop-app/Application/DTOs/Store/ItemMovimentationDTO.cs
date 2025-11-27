using System.ComponentModel.DataAnnotations;

namespace Bag_and_Shop_app.Application.DTOs.Store
{
    public class ItemMovimentationDTO : StoreBaseReqDTO
    {
        [Range(1, int.MaxValue, ErrorMessage = "O Id do Item é obrigatório e deve ser um valor válido (maior que zero).")]
        public int ItemId { get; set; }
        public int Quantity { get; set; } = 1;
        public double Price { get; set; } = 0;

    }
}
