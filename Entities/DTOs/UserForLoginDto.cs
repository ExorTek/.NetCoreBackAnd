using Core.Entities;

namespace Entities.DTOs
{
    public class UserForLoginDto : IDto
    {
        //we write our data transfer objects
        public string Email { get; set; }
        public string Password { get; set; }
    }
}