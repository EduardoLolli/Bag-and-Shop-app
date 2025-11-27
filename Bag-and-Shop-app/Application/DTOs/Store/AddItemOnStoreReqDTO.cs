using System.ComponentModel.DataAnnotations;

namespace Bag_and_Shop_app.Application.DTOs.Store
{
    public class AddItemOnStoreReqDTO : StoreBaseReqDTO
    {
        [Required(ErrorMessage = "O campo ItemId é obrigatório.")]
        public int ItemId { get; set; }
        [Required(ErrorMessage = "O campo Quantity é obrigatório.")]
        public int Quantity { get; set; } = 0;
    }
}
