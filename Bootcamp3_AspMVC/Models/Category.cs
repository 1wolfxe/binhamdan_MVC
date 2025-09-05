

using System.ComponentModel.DataAnnotations;

namespace Bootcamp3_AspMVC.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        public  string Name { get; set; }
        public string? Discraption { get; set; }
    }
}
