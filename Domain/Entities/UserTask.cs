

using DOMAIN.Enums;
using System.ComponentModel.DataAnnotations;

namespace DOMAIN.Entities
{
    public class UserTask
    {
        [Key]
        public Guid Id { get; set; }
        [Required(ErrorMessage = "Title is required")]
        public string Title { get; set; } = null!;
        public string? Description { get; set; }
        public DateTime DueDate { get; set; }
        public Priority Priority { get; set; }
        public Status Status { get; set; }

        public Guid ProjectId { get; set; }
        public Project? Project { get; set; }

        public Guid UserId { get; set; }
        public User? User { get; set; }

        public virtual ICollection<Notification>? Notifications { get; set; }
    }
}
