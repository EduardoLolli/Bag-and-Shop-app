namespace Bag_and_Shop_app.Application.DTOs.Character
{

    public class CharacterCreationResponseDTO
    {

        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
    }
}