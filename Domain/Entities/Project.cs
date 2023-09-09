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

        public Guid ProjectOwnerId { get; set; }
        public User? ProjectOwner { get; set; }
        public virtual ICollection<UserTask>? Tasks { get; set; }
        public virtual ICollection<Notification>? Notifications { get; set; }
    }
}
