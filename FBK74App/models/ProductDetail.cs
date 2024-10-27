using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FBK74App.models
{
    public class ProductDetail
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int ProductId { get; set; }
        public virtual Product? Product { get; set; }
        public int Quantity { get; set; }
        public int BillId { get; set; }
        public virtual Bill? Bill { get; set; }
    }
}
