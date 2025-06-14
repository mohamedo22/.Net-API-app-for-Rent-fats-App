using System.ComponentModel.DataAnnotations;

namespace test.Dto
{
    public class ForgetDto
    {
        [EmailAddress(ErrorMessage = "Must be a Valid Email")]
        [Required(ErrorMessage = "Can't be Empty")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Can't be Empty")]
        public string New_Password{ get; set; }
        [Compare("New_Password",ErrorMessage ="Confirm Password Must be Matching Password")]
        public string Password { get; set; }
    }
}
