using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TemplateRestAPI.Entities
{
    [Table(nameof(Account))]
    [Index(nameof(PhoneNumber), IsUnique = true)]
    [Index(nameof(Email), IsUnique = true)]
    public class Account
    {
        [Key]
        public Guid Id { get; set; }

        [MaxLength(15)]
        public string PhoneNumber { get; set; }

        [MaxLength(500)]
        public string Email { get; set; }

        [MaxLength(100)]
        public string Password { get; set; }

        public DateTime CreatedTime { get; set; }
    }
}
