using System.ComponentModel.DataAnnotations;

namespace test.Model
{
    public class Admin
    {
        [Key]
        public int AdminId { get; set; }
        public string AdminEmail { get; set; }
        public string AdminPassword { get; set; }

    }
}
