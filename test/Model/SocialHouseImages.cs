using System.ComponentModel.DataAnnotations;

namespace test.Model
{
    public class SocialHouseImages
    {
        [Key]
        public int SocialHouseImagesId {  get; set; }
        public int SocialHouseId { get; set; }
        public SocialHouse SocialHouse { get; set; }
        public byte[] image { get; set; }

    }
}
