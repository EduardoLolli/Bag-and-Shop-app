using System.ComponentModel.DataAnnotations;

namespace Bag_and_Shop_app.Application.DTOs.Character
{

    public class CharacterCreationResponseDTO
    {

        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public int UserId { get; set; }
        public int BagId { get; set; }
        public double Gold { get; set; }
        public object Campaign { get; set; } = null!;
        public int BodyId { get; set; }
    }
}