using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace test.Model
{
    public class FlatImagesDocs
    {
        [Key]
        public int FlatImagesDocsId { get; set; }
        [ForeignKey("FlatCodeId")]
        public Flat Flat { get; set; }
        public int FlatCodeId { get; set; }
        public byte[] Flatimage { get; set; }
    }
}
