namespace HospiceWebPortal.Migrations
{
    using HospiceWebPortal.Models;
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<HospiceWebPortal.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(HospiceWebPortal.Models.ApplicationDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //

            //Role Manager
            var roleManager = new RoleManager<IdentityRole>(new
                                          RoleStore<IdentityRole>(context));
            //Create Admin Role
            if (!context.Roles.Any(r => r.Name == "Admin"))
            {
                var roleresult = roleManager.Create(new IdentityRole("Admin"));
            }

            //Create Staff Roles
            if (!context.Roles.Any(r => r.Name == "Leadership"))
            {
                var roleresult = roleManager.Create(new IdentityRole("Leadership"));
            }
            if (!context.Roles.Any(r => r.Name == "Staff_Admin"))
            {
                var roleresult = roleManager.Create(new IdentityRole("Staff_Admin"));
            }
            if (!context.Roles.Any(r => r.Name == "Community"))
            {
                var roleresult = roleManager.Create(new IdentityRole("Community"));
            }
            if (!context.Roles.Any(r => r.Name == "Outreach"))
            {
                var roleresult = roleManager.Create(new IdentityRole("Outreach"));
            }
            if (!context.Roles.Any(r => r.Name == "Residential"))
            {
                var roleresult = roleManager.Create(new IdentityRole("Residential"));
            }
            if (!context.Roles.Any(r => r.Name == "New Staff"))
            {
                var roleresult = roleManager.Create(new IdentityRole("New Staff"));
            }

            //Create Board Roles
            if (!context.Roles.Any(r => r.Name == "Audit_Finance"))
            {
                var roleresult = roleManager.Create(new IdentityRole("Audit_Finance"));
            }
            if (!context.Roles.Any(r => r.Name == "Community_Relations"))
            {
                var roleresult = roleManager.Create(new IdentityRole("Community_Relations"));
            }
            if (!context.Roles.Any(r => r.Name == "Governance_Committee"))
            {
                var roleresult = roleManager.Create(new IdentityRole("Governance_Committee"));
            }
            if (!context.Roles.Any(r => r.Name == "Operations"))
            {
                var roleresult = roleManager.Create(new IdentityRole("Operations"));
            }
            if (!context.Roles.Any(r => r.Name == "New_Board"))
            {
                var roleresult = roleManager.Create(new IdentityRole("New_Board"));
            }

            //Create Voluneteer Roles
            if (!context.Roles.Any(r => r.Name == "Bereavement"))
            {
                var roleresult = roleManager.Create(new IdentityRole("Bereavement"));
            }
            if (!context.Roles.Any(r => r.Name == "Community"))
            {
                var roleresult = roleManager.Create(new IdentityRole("Community"));
            }
            if (!context.Roles.Any(r => r.Name == "Day_Hospice"))
            {
                var roleresult = roleManager.Create(new IdentityRole("Day_Hospice"));
            }
            if (!context.Roles.Any(r => r.Name == "Residential"))
            {
                var roleresult = roleManager.Create(new IdentityRole("Residential"));
            }
            if (!context.Roles.Any(r => r.Name == "Welcome_Desk"))
            {
                var roleresult = roleManager.Create(new IdentityRole("Welcome_Desk"));
            }
            if (!context.Roles.Any(r => r.Name == "Event_Non-Client"))
            {
                var roleresult = roleManager.Create(new IdentityRole("Event_Non-Client"));
            }
            if (!context.Roles.Any(r => r.Name == "Admin_Non-Client"))
            {
                var roleresult = roleManager.Create(new IdentityRole("Admin_Non-Client"));
            }
            if (!context.Roles.Any(r => r.Name == "New_Volunteers"))
            {
                var roleresult = roleManager.Create(new IdentityRole("New_Volunteers"));
            }

            //Create a few generic users
            var manager = new UserManager<ApplicationUser>(
                new UserStore<ApplicationUser>(context));

            var admin = new ApplicationUser
            {
                UserName = string.Format("admin@outlook.com"),
                Email = string.Format("admin@outlook.com")
            };
            if (!context.Users.Any(u => u.UserName == admin.UserName))
            {
                manager.Create(admin, "Password1!");
                manager.AddToRole(admin.Id, "Admin");
            }

            //var daduser = new ApplicationUser
            //{
            //    UserName = "dad@outlook.com",
            //    Email = "dad@outlook.com"
            //};
            //if (!context.Users.Any(u => u.UserName == daduser.UserName))
            //{
            //    manager.Create(daduser, "Password1!");
            //    manager.AddToRole(daduser.Id, "Parent");
            //}
            //var teenuser = new ApplicationUser
            //{
            //    UserName = "teenager1@outlook.com",
            //    Email = "teenager1@outlook.com"
            //};
            //if (!context.Users.Any(u => u.UserName == teenuser.UserName))
            //{
            //    manager.Create(teenuser, "Password1!");
            //    manager.AddToRole(teenuser.Id, "Babysitter");
            //}
        }
    }
}
