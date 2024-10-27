using FBK74App.Interface;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FBK74App.models
{
    public class FootballField : Tracking
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string? Name { get; set; }
        public decimal Price { get; set; }
        public string? Image { get; set; }
        public string? Address { get; set; }
        public string? Description { get; set; }
        public string? Status { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
        public virtual IEnumerable<FootballFieldSchedule>? FootballFieldSchedules { get; set; }
    }
}
