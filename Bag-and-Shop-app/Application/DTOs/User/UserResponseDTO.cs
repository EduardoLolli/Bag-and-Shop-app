
namespace Bag_and_Shop_app.Application.DTOs.User
{
    public class UserResponseDTO
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public List<UserResponseDTO> Users { get; internal set; }
    }
}
