

using DOMAIN.Enums;
using System.ComponentModel.DataAnnotations;

namespace DOMAIN.Entities
{
    public class Notification
    {
        public Guid Id { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "A notification message is required")]
        public string Message { get; set; } = null!;
        public NotificationType Type { get; set; }
        public DateTime TimeStamp { get; set; } = DateTime.Now;


        public Guid UserId { get; set; }
        public User? User { get; set; }


        public virtual ICollection<UserTask>? Tasks { get; set; }
        public virtual ICollection<Project>? Projects { get; set; }
    }
}
