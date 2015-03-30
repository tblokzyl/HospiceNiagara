using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace HospiceWebPortal.Models
{
    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit http://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    public class ApplicationUser : IdentityUser
    {
        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            // Add custom user claims here
            return userIdentity;
        }
    }

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("HospiceWebPortalEntities", throwIfV1Schema: false)
        {

        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }

            public DbSet<Home> Homes { get; set; }
            public DbSet<Admin> Admins { get; set; }
            public DbSet<Announcement> Announcements { get; set; }
            public DbSet<Resource> Resources { get; set; }
            public DbSet<Meeting> Meetings { get; set; }
            public DbSet<Schedule> Schedules { get; set; }
            public DbSet<Contact> Contacts { get; set; }

            protected override void OnModelCreating(DbModelBuilder modelBuilder)
            {
                //Prevents cascaade deleting

                base.OnModelCreating(modelBuilder);

                modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            }

            public System.Data.Entity.DbSet<HospiceWebPortal.Models.DeathNotification> DeathNotifications { get; set; }



            //public System.Data.Entity.DbSet<HospiceWebPortal.Models.Home> Homes { get; set; }

            //public System.Data.Entity.DbSet<HospiceWebPortal.Models.Announcement> Announcements { get; set; }

            //public System.Data.Entity.DbSet<HospiceWebPortal.Models.Admin> Admins { get; set; }

            //public System.Data.Entity.DbSet<HospiceWebPortal.Models.Contact> Contacts { get; set; }

            //public System.Data.Entity.DbSet<HospiceWebPortal.Models.Meeting> Meetings { get; set; }

            //public System.Data.Entity.DbSet<HospiceWebPortal.Models.Resource> Resources { get; set; }

            //public System.Data.Entity.DbSet<HospiceWebPortal.Models.Schedule> Schedules { get; set; }
    }
}