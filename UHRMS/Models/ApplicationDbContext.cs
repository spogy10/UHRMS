using Microsoft.AspNet.Identity.EntityFramework;
using System.Data.Entity;

namespace UHRMS.Models
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public DbSet<Student> Students { get; set; }

        public DbSet<Dorm> Dorms { get; set; }
        public DbSet<Room> Rooms { get; set; }

        public DbSet<Payment> Payments { get; set; }

        public DbSet<AccoStaff> AccoStaffs { get; set; }

        public DbSet<BoardingApplicationForm> BoardingForms { get; set; }

        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
            
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }
    }
}