namespace test.Dto
{
    public class GetFlatDto
    {
        public int FlatPrice { get; set; }
        public int FlatBathrooms { get; set; }
        public int FlatBedrooms { get; set; }
        public int FloorNumber { get; set; }
        public string FlatGovernorate { get; set; }
        public string FlatCity { get; set; }
        public string FlatDetails { get; set; }
        public string FlatAddress { get; set; }
        public string Status { get; set; } = "Waiting";
        public int FlatId { get; set; }
        public List<FlatImagesGetDto> FlatImages { get; set; }
        public List<FlatImagesGetDto> FlatImagesDocs { get; set; }
    }
}
