using System.ComponentModel.DataAnnotations;

namespace Bag_and_Shop_app.Application.DTOs.Character
{

    public class BagResponseDTO
    {

        public int Id { get; set; }
        public decimal Gold { get; set; }
        public double WeightLimit { get; set; }
        public double CurrentWeight { get; set; }
        public int CharacterId { get; set; }
    }
}