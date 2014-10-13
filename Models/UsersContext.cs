namespace Eden.Models
{
    using System.Data.Entity;

    public class UsersContext : DbContext
    {
        public UsersContext()
            : base("Eden")
        {
        }

        public DbSet<UserProfile> UserProfiles { get; set; }
    }
}
