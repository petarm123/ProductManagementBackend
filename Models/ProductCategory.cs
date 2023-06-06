using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ProductManagement.Models
{
    public class ProductCategory
    {
        [Key, Column(Order = 0)]
        [ForeignKey("Product")]
        public int productId { get; set; }
        public Product Product { get; set; } = null!;

        [Key, Column(Order = 1)]
        [ForeignKey("Category")]
        public int categoryId { get; set; }
        public Category Category { get; set; } = null!;
    }
}
