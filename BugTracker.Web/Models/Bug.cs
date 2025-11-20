using System.ComponentModel.DataAnnotations;

namespace BugTracker.Web.Models
{
    public class Bug
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Title { get; set; } = string.Empty;

        [Required]
        public string Description { get; set; } = string.Empty;

        [Required]
        public string Priority { get; set; } = "Medium";

        [Required]
        public string Status { get; set; } = "Open";

        public DateTime CreatedAt { get; set; } = DateTime.Now;
    }
}