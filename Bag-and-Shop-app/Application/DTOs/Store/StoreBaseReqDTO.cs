using System.ComponentModel.DataAnnotations;

namespace Bag_and_Shop_app.Application.DTOs.Store
{
    public class StoreBaseReqDTO
    {
        [Required(ErrorMessage = "O campo StoreId é obrigatório.")]
        public int StoreId { get; set; }
    }
}
