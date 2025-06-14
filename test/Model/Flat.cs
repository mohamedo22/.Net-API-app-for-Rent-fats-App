using System.ComponentModel.DataAnnotations;

namespace test.Model
{
    public class Flat
    {
        [Key]
        public int FlatCodeId { get; set; }
        public int FlatPrice { get; set; }
        public int FlatBathrooms { get; set; }
        public int FlatBedrooms { get; set; }
        public int FloorNumber  { get; set; }
        public string FlatGovernorate  { get; set; }
        public string FlatCity  { get; set; }
        public string FlatDetails { get; set; }
        public string  FlatAddress { get; set; }
        public string Status { get; set; } = "Waiting";
        public List<FlatImages>  FlatImages { get; set; }
        public List<FlatImagesDocs>  FlatImagesDocs { get; set; }
        public ContactUsRequest ContactUsRequest { get; set; }
    }
}
