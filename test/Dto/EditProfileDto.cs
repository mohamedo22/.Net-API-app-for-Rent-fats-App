using System.ComponentModel.DataAnnotations;

namespace test.Dto
{
    public class EditProfileDto
    {
        public int userId { get; set; }
        [Required(ErrorMessage = "Can't be Empty")]
        [Length(11,11, ErrorMessage = "Phone must be 11 Number")]
        public string Phone { get; set; }
        [Required(ErrorMessage = "Can't be Empty")]
        public string Username { get; set; }
        [EmailAddress(ErrorMessage ="Must be valid a Email ")]
        [Required(ErrorMessage = "Can't be Empty")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Can't be Empty")]
        public string Address { get; set; } 
    }
}
