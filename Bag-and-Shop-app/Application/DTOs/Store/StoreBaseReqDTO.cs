using System.ComponentModel.DataAnnotations;

namespace Bag_and_Shop_app.Application.DTOs.Store
{
    public class StoreBaseReqDTO
    {
        [Range(1, int.MaxValue, ErrorMessage = "O Id da loja é obrigatório e deve ser um valor válido (maior que zero).")]
        public int StoreId { get; set; }
    }
}
