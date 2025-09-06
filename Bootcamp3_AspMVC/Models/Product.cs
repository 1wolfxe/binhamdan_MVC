using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bootcamp3_AspMVC.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }
        public double Price { get; set; }
        public string? img { get; set; }

        [ForeignKey("Category")]
        public int? CategoryId { get; set; }

        public Category? Category { get; set; }

    }
}
