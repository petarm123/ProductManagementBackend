using System.ComponentModel.DataAnnotations;

namespace ProductManagement.Models
{
    public class Product
    {
        [Key]
        public int productId { get; set; }
        public string? name { get; set; }
        public string? description { get; set; }
        public decimal? price { get; set; } 

        public ICollection<Category>? Categories { get; set; }
        
    }
}
