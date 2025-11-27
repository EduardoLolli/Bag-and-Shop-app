using System.ComponentModel.DataAnnotations;

namespace Bag_and_Shop_app.Application.DTOs.Character
{

    public class BagResponseDTO
    {

        public int Id { get; set; }
        public Double Gold { get; set; }
        public Double WeightLimit { get; set; }
        public Double CurrentWeight { get; set; }
        public int CharacterId { get; set; }
    }
}