

using DOMAIN.Enums;
using System.ComponentModel.DataAnnotations;

namespace DOMAIN.Entities
{
    public class Notification
    {
        public Guid Id { get; set; }
        public string Message { get; set; } = null!;
        public NotificationType Type { get; set; }
        public DateTime TimeStamp { get; set; } = DateTime.Now;


        public Guid UserId { get; set; }
        public User? User { get; set; }


        public virtual ICollection<Task>? Tasks { get; set; }
        public virtual ICollection<Project>? Projects { get; set; }
    }
}
