using System.ComponentModel.DataAnnotations;

namespace test.Dto
{
    public class PostFlatDto
    {
        [Required(ErrorMessage = "Flat Price Can't be Empty")]
        public int FlatPrice { get; set; }
        [Required(ErrorMessage = "Flat Bathroom numbers Can't be Empty")]
        public int FlatBathrooms { get; set; }
        [Required(ErrorMessage = "Flat Bedroom numbers Can't be Empty")]
        public int FlatBedrooms { get; set; }
      [Required(ErrorMessage = "Flat Bathroom numbers Can't be Empty")]
        public int FloorNumber { get; set; }
        [Required(ErrorMessage = "Flat Details Can't be Empty"), MaxLength(1500)]
        public string FlatDetails { get; set; }
        [Required(ErrorMessage = "Flat Address Can't be Empty"), MaxLength(1500)]
        public string FlatAddress { get; set; }
        [Required(ErrorMessage = "Flat Governorate  Can't be Empty"), MaxLength(50)]
        public string FlatGovernorate { get; set; }
        [Required(ErrorMessage = "Flat City Can't be Empty"), MaxLength(50)]
        public string FlatCity { get; set; }
        public string? Status { get; set; } = "Waiting";
        [Required(ErrorMessage = "Flat Images Can't be Empty")]
        public List<IFormFile> FlatImages { get; set; }
        [Required(ErrorMessage = "Flat Docs Can't be Empty")]
        public List<IFormFile> FlatImagesDocs { get; set; }
    }
}
