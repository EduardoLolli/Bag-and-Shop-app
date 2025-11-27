using System.ComponentModel.DataAnnotations;

namespace Bag_and_Shop_app.Application.DTOs.Store
{
    public class RemoveItemDTO : StoreBaseReqDTO
    {
        [Required(ErrorMessage = "O campo ItemID é obrigatório.")]
        public int ItemId { get; set; }
    }
}
