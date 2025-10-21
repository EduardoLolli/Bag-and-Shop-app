using System.ComponentModel.DataAnnotations;

namespace Bag_and_Shop_app.Application.DTOs.Character
{

    public class CharacterResponseDTO
    {

        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public int UserId { get; set; }
        
    }
}