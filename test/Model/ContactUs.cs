using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.CompilerServices;

namespace test.Model
{
    public class ContactUsRequest
    {
        //this 

        [Key]
        public int ContactUsId { get; set; }
        [ForeignKey("FlatCodeId")]
        public Flat Flat { get; set; }
        public int FlatCodeId { get; set; }
        [ForeignKey("UserId")]
        public User User { get; set; }
        public int UserId { get; set; }
        public DateTime dataTime { get; set; }



    }
}
