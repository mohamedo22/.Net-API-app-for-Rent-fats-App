using System.ComponentModel.DataAnnotations;

namespace test.Dto
{
    public class LoginDto
    {
        [Required(ErrorMessage = "Can't be Empty")]
        public string Username { get; set; }
        [Required(ErrorMessage = "Can't be Empty")]
        public string Password { get; set; }
    }
}
