
using System.ComponentModel.DataAnnotations;


namespace DOMAIN.Entities
{
    public class User
    {
        public Guid Id { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "User name is required")]
        public string Name { get; set; } = null!;
        [Required(AllowEmptyStrings = false, ErrorMessage = "User email is required")]
        [EmailAddress]
        public string Email { get; set; } = null!;

        public virtual ICollection<Task>? Tasks { get; set; }

        public virtual ICollection<Notification>? Notifications { get; set; }
    }
}
