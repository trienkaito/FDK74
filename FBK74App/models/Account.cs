using FBK74App.Interface;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FBK74App.models
{
    public class Account : Tracking
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public required string UserName { get; set; }
        public required string Password { get; set; }
        public string? Email { get; set; }
        public string? PhoneNumber { get; set; }
        public required string Role { get; set; }
        public string? Status { get; set; }

        // Implementing Tracking properties
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
        public virtual IEnumerable<Bill>? Bills { get; set; }
    }
}
