using FBK74App.Interface;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FBK74App.models
{
    public class Product : Tracking
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public required string Name { get; set; }
        public string? Description { get; set; }
        public required string Image { get; set; }
        public int Quantity { get; set; }
        public DateTime CreatedDate { get ; set ; }
        public DateTime UpdatedDate { get; set; }
        public virtual IEnumerable<ProductDetail>? ProductDetails { get; set; }

    }
}
