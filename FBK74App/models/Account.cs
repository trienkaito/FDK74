using FBK74App.Interface;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FBK74App.models
{
    public enum AccountType
    {
        Member = 0,
        Admin = 1
    }
    public class Account : Tracking
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public required string UserName { get; set; }
        public required string Password { get; set; }
        public string? Email { get; set; }
        public string? PhoneNumber { get; set; }
        public AccountType Type { get; set; }
        public string? Status { get; set; }

        // Implementing Tracking properties
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
        public virtual IEnumerable<Bill>? Bills { get; set; }
    }
}
