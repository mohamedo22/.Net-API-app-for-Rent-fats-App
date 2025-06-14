using System.ComponentModel.DataAnnotations;

namespace test.Dto
{
    public class UserDto
    {
        [Required(ErrorMessage ="Can't be Empty")]
        public string Username { get; set; }
        [Required(ErrorMessage = "Can't be Empty")]
        [Length(14, 14, ErrorMessage = "PersonalID num must be 14 Number")]
        public string National_Id { get; set; }
        [Required(ErrorMessage = "Can't be Empty")]
        public DateTime BirthDate { get; set; }
        [Required(ErrorMessage = "Can't be Empty")]
        [Length(11, 11, ErrorMessage = "Phone must be 11 Number")]
        public string Phone { get; set; }
        [Required(ErrorMessage = "Can't be Empty")]
        public string Password { get; set; }
        [EmailAddress(ErrorMessage = "Can't be Empty")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Can't be Empty")]
        public string Address { get; set; }
    }

    public class UserGetDto
    {
        [Required(ErrorMessage = "Can't be Empty")]
        public string Username { get; set; }
        [Required(ErrorMessage = "Can't be Empty")]
        [Length(14, 14, ErrorMessage = "PersonalID num must be 14 Number")]
        public string Phone { get; set; }
        [EmailAddress(ErrorMessage = "Can't be Empty")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Can't be Empty")]
        public string Address { get; set; }
    }
}
