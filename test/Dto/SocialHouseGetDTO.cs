namespace test.Dto
{
    public class SocialHouseGetDTO
    {
        public string title { get; set; }
        public string description { get; set; }
        public string address { get; set; }
        public string category { get; set; }
        public string terms { get; set; }
        public int Socialid { get; set; }
        public List<SocialHouseImagesGetDTO> socialHouseImages { get; set; }
    }
}
