using FBK74App.Interface;
using Microsoft.AspNetCore.Mvc.Diagnostics;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FBK74App.models
{
    public class RegisteredFootballField : Tracking
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public required string Name { get; set; }
        public decimal Deposit { get; set; }
        public int Account1Id { get; set; }
        [ForeignKey("Account1Id")]
        public virtual Account? Account1 { get; set; }
        public int Account2Id { get; set; }
        [ForeignKey("Account2Id")]
        public virtual Account? Account2 { get; set; }
        public int RegistFindOppoentId {get; set; }
        [ForeignKey("RegistFindOppoentId")]
        public virtual RegistFindOppoent? RegistFindOppoent { get; set; }
        public int FootballFieldScheduleId { get; set; }
        [ForeignKey("FootballFieldScheduleId")]
        public virtual FootballFieldSchedule? FootballFieldSchedule { get; set; }
        public DateTime Date { get; set; }
        public string? Status { get; set; }
        public string? Note { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
        
        public virtual IEnumerable<Bill>? Bills { get; set; }

    }
}
