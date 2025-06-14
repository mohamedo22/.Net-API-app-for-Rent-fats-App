using System.ComponentModel.DataAnnotations;

namespace test.Model
{
    public class User
    {
        [Key] 
        public int UserId { get; set; }
        public string Username { get; set; } 
        public string National_Id{ get; set; } 
        public DateTime BirthDate { get; set; }
        public string Phone { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public ContactUsRequest ContactUsRequest { get; set; }
    }
}
