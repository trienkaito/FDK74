using FBK74App.Interface;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FBK74App.models
{
    public class Bill : Tracking
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string? Invoice { get;set; }
        public int RegisteredFootballFieldId { get; set; }
        [ForeignKey("RegisteredFootballFieldId")]
        public virtual RegisteredFootballField? RegisteredFootballField { get; set; }
        //public int RegistFindOppoentId { get; set; }
        //public virtual RegistFindOppoent? RegistFindOppoent { get; set; }
        public int Account2Id { get; set; }
        [ForeignKey("Account2Id")]
        public virtual Account? Account2 { get; set; }
        public DateTime PaymentDate { get; set; }
        public DateTime CreatedDate { get ; set; }
        public DateTime UpdatedDate { get; set; }

        public virtual IEnumerable<ProductDetail>? Products { get; set; }
    }
}
