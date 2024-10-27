using FBK74App.Interface;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FBK74App.models
{
    public class RegistFindOppoent : Tracking
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public int Account1Id { get; set; }
        [ForeignKey("Account1Id")]
        public virtual Account? Account1 { get; set; }

        public int Account2Id { get; set; }
        [ForeignKey("Account2Id")]
        public virtual Account? Account2 { get; set; }

        public required string Name { get; set; }
        public string? Phone { get; set; }

        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public DateTime Date { get; set; }

        public string? Power { get; set; }
        public int TypeOfFootballField { get; set; }
        public decimal Deposit { get; set; }
        public int Status { get; set; }

        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
    }
}
