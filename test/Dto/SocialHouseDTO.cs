using System.ComponentModel.DataAnnotations;
using test.Model;

namespace test.Dto
{
    public class SocialHouseDTO
    {
        [Required(ErrorMessage = "Social Housing Title Can't be Empty")]
        public string title { get; set; }
        [Required(ErrorMessage = "Social Housing Description Can't be Empty")]
        public string description { get; set; }
        [Required(ErrorMessage = "Social Housing Address Can't be Empty")]
        public string address { get; set; }
        [Required(ErrorMessage = "Social Housing Categories Can't be Empty")]
        public string category { get; set; }
        [Required(ErrorMessage = "Social Housing Terms Can't be Empty")]
        public string terms { get; set; }
        [Required(ErrorMessage = "Social Housing Images Can't be Empty")]
        public List<IFormFile> socialHouseImages { get; set; }
    }
}
