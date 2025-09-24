using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UserManagementApp.Models
{
    public class Event
    {
        [Key]
        public int Id { get; set; }

        [Required, MaxLength(200)]
        public string Title { get; set; } = string.Empty;

        public string? Description { get; set; }

        [Required]
        public string EventType { get; set; } = string.Empty; // workshop, seminar, etc.

        [Required]
        public DateTime Date { get; set; }

        public string? Location { get; set; }

        // 🔹 Use Guid for BranchId since University/Branches use Guid
        [Required]
        public Guid BranchId { get; set; }

        [ForeignKey("BranchId")]
        public University? Branch { get; set; }

        // 🔹 Match User Id type (int, because User.Id is int)
        [Required]
        public int CreatedBy { get; set; }

        [ForeignKey("CreatedBy")]
        public User? Creator { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;
    }
}
