using System.ComponentModel.DataAnnotations;


namespace DOMAIN.Entities
{
    public class Project
    {
        [Key]
        public Guid Id { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "Name is required")]
        public string Name { get; set; } = null!;
        public string? Description { get; set; }
        public virtual ICollection<Task>? Tasks { get; set; }
        public virtual ICollection<Notification>? Notifications { get; set; }
    }
}
