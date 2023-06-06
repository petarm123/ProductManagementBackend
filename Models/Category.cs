using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace ProductManagement.Models
{
    public class Category
    {
        [Key]
        public int categoryId { get; set; }
        public string? name { get; set; } 
        
        public ICollection<Product>? Products { get; set; }
    }
}
