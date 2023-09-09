using Microsoft.AspNetCore.Identity;



namespace DOMAIN.Entities
{
    public class User: IdentityUser
    {
       

        public virtual ICollection<UserTask>? Tasks { get; set; }
        public virtual ICollection<Project>? Projects { get; set; }
        public virtual ICollection<Notification>? Notifications { get; set; }
    }
}
