using System.ComponentModel.DataAnnotations;

namespace MyApplication.Models
{
    public class Category
    {
        [Key]
        public int id { get; set; }

        [Required]
        public string name { get; set; }

        public int DisplayeOrder { get; set; }

        public DateTime CreatedDateTime { get; set; } = DateTime.Now;
    }
}
