using System.ComponentModel.DataAnnotations;
using test.Model;

namespace test.Dto
{
    public class ContactUsDto
    {
        public int FlatCodeId { get; set; }
        public int UserId { get; set; }
        public DateTime dataTime { get; set; }
        public string userPhone { get; set; }

    }
}
