namespace HospiceWebPortal.Migrations
{
    using HospiceWebPortal.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Data.Entity.Validation;
using System.Linq;
using System.Text;

    internal sealed class Configuration : DbMigrationsConfiguration<HospiceWebPortal.DAL.HospiceWebPortalEntities>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(HospiceWebPortal.DAL.HospiceWebPortalEntities context)
        {
            var homeArticles = new List<Home>
            {
                new Home 
                { 
                    Title = "Nullam fringilla mattis tincidunt", 
                    Content = "Contrary to popular belief, Lorem Ipsum is not simply random text. It has roots in a piece of classical Latin literature from 45 BC, making " 
                    + "it over 2000 years old. Richard McClintock, a Latin professor at Hampden-Sydney College in Virginia, looked up one of the more obscure Latin words, "
                    + "consectetur, from a Lorem Ipsum passage, and going through the cites of the word in classical literature, discovered the undoubtable source. Lorem Ipsum "
                    + "comes from sections 1.10.32 and 1.10.33 of de Finibus Bonorum et Malorum (The Extremes of Good and Evil) by Cicero, written in 45 BC. This book is a treatise "
                    + "on the theory of ethics, very popular during the Renaissance. The first line of Lorem Ipsum, Lorem ipsum dolor sit amet.., comes from a line in section 1.10.32.",
                    Created = DateTime.Parse("2011-03-12"), 
                    Author = "Tim Blokzyl"
                },

                new Home 
                {  
                    Title = "Suspendisse tincidunt tellus in cursus", 
                    Content = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Phasellus et quam libero. Ut viverra erat eu placerat tincidunt. Maecenas vehicula tortor ut " 
                    + "ullamcorper lacinia. Duis feugiat enim turpis, efficitur faucibus quam fermentum nec. Donec sodales tincidunt nisl, sed hendrerit felis feugiat sed. Aliquam eu urna " 
                    + "dolor. Fusce tincidunt sapien risus, nec aliquet justo iaculis eget. Vestibulum a quam massa. Mauris id massa sed dui pellentesque porttitor. Ut lorem ante, efficitur " 
                    + "id ex id, lobortis pulvinar orci. Nullam sollicitudin vel erat a finibus. Fusce gravida ullamcorper ultrices. Nam dictum felis at imperdiet aliquet. Quisque a orci ut " 
                    + "felis feugiat pretium quis non ante. Cras purus turpis, venenatis sit amet fermentum hendrerit, fringilla sit amet orci. Quisque dapibus ipsum ipsum, eu varius augue" 
                    + "interdum eu. \r\n\r\n Etiam tempor vitae velit ac maximus. Aliquam ultricies malesuada felis, at ultrices turpis tempor eget. Nullam eget tincidunt mauris. Donec eget orci" 
                    + "eget ipsum commodo eleifend vel vel lorem. Sed et urna feugiat, eleifend massa non, mollis dui. Sed lobortis pulvinar facilisis. Sed magna sapien, sollicitudin vel " 
                    + "blandit sed, porta et enim.", 
                    Created = DateTime.Parse("2011-03-12"), 
                    Author = "Hospice Niagara"
                },

                new Home 
                { 
                    Title = "Lorem ipsum dolor sit amet", 
                    Content = "Aenean tristique at tellus quis consequat. Aenean ex nibh, fringilla a nulla in, elementum ultricies tortor. Nullam at gravida lacus. Integer molestie odio non " 
                    + "nunc dictum venenatis. Fusce ultrices dignissim eleifend. Nulla facilisi. Nunc purus lorem, ultricies ut tellus at, vehicula semper sem. Fusce sit amet massa ligula. " 
                    + "Donec vel fringilla arcu. Suspendisse diam orci, interdum in tortor ac, tincidunt hendrerit arcu. Integer dolor metus, tempor ac mi vel, interdum hendrerit erat. Fusce " 
                    + "eu convallis dolor. Curabitur faucibus libero in neque euismod vehicula. Nullam vel finibus nisl, faucibus eleifend ex. \r\n\r\n"
                    + "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nunc tincidunt blandit urna sed pellentesque. Nam eget quam at dolor molestie placerat. Praesent viverra enim " 
                    + "nec ante hendrerit, ac consequat est eleifend. Fusce id diam finibus, condimentum lacus ut, lobortis odio. Aliquam dictum euismod sem posuere ultricies. Praesent eget " 
                    + "est velit. Aenean a lectus non lectus commodo sollicitudin ut a sapien. Aliquam in porttitor lectus, ac rutrum ipsum. Nulla ut consequat nisi, et pharetra dolor. " 
                    + "Pellentesque condimentum accumsan nisl non volutpat. Aliquam rutrum efficitur faucibus. Donec quis sodales eros. Nulla vestibulum tempus purus non pharetra. \r\n\r\n"
                    + "Nam facilisis sodales tortor et viverra. Donec sollicitudin auctor lectus, sed vestibulum libero elementum vitae. Pellentesque vel nulla mi. Nam arcu sapien, lobortis vel " 
                    + "sem at, malesuada viverra ex. Phasellus eros orci, lacinia eget metus a, porta fermentum enim. Praesent eu venenatis mauris, vitae scelerisque massa. Nam dictum, lorem " 
                    + "id egestas posuere, risus odio tempor mi, in mollis nulla sem vel libero. Aenean in magna sed libero vestibulum ultrices. Fusce libero ipsum, ultricies non viverra in, " 
                    + "tincidunt vel velit.", 
                    Created = DateTime.Parse("2011-03-12"), 
                    Author = "Hospice Niagara"
                }
            };
            homeArticles.ForEach(d => context.Homes.AddOrUpdate(n => n.Title, d));
            context.SaveChanges();

            var contacts = new List<Contact>
            {
                new Contact 
                { 
                    FirstName = "Timothy",
                    LastName = "Blokzyl",
                    Position = "Lead Programmer",
                    Phone = 1234567890,
                    EXT = 777
                },
                new Contact 
                { 
                    FirstName = "Alice",
                    LastName = "Merry",
                    Position = "Community Relations Manager",
                    EXT = 230
                },
                new Contact 
                { 
                    FirstName = "Andrea",
                    LastName = "Crompton",
                    Position = "Community Relations Associate",
                    EXT = 231
                },
                new Contact 
                { 
                    FirstName = "Barbara",
                    LastName = "Cowell",
                    Position = "Executive Assistant",
                    EXT = 223
                },
                new Contact 
                { 
                    FirstName = "Barb",
                    LastName = "Nolan",
                    Position = "Day Hospice Coordinator",
                    EXT = 270
                },
                new Contact 
                { 
                    FirstName = "Carol",
                    LastName = "Nagy",
                    Position = "Executive Director",
                    Phone = 2894078197,
                    EXT = 225
                },
                new Contact 
                { 
                    FirstName = "Diane",
                    LastName = "Fahlman",
                    Position = "Legacy Associate",
                    EXT = 250
                },
                new Contact 
                { 
                    FirstName = "Diane",
                    LastName = "Reid",
                    Position = "Palliative Care Consultant",
                    Phone = 9055156276,
                    EXT = 232
                },
                new Contact 
                { 
                    FirstName = "Dorothy",
                    LastName = "Hunse",
                    Position = "Chaplain/Psychosocial-Spiritual Advisor",
                    EXT = 249
                },
                new Contact 
                { 
                    FirstName = "Brian",
                    LastName = " Kerley",
                    Position = "Medical Director",
                    Phone = 9056415684,
                    EXT = 234
                },
                new Contact 
                { 
                    FirstName = "Jessica",
                    LastName = "Estabrooks",
                    Position = "Finance and Operations Manager",
                    EXT = 238
                }
            };
            contacts.ForEach(d => context.Contacts.AddOrUpdate(n => n.ID, d));
    try
    {
        context.SaveChanges();
    }
    catch (DbEntityValidationException ex)
    {
        var sb = new StringBuilder();
        foreach (var failure in ex.EntityValidationErrors)
        {
            sb.AppendFormat("{0} failed validation\n", failure.Entry.Entity.GetType());
            foreach (var error in failure.ValidationErrors)
            {
                sb.AppendFormat("- {0} : {1}", error.PropertyName, error.ErrorMessage);
                sb.AppendLine();
            }
        }
        throw new DbEntityValidationException(
            "Entity Validation Failed - errors follow:\n" +
            sb.ToString(), ex
        );
    }

            ////Role Manager
            //var roleManager = new RoleManager<IdentityRole>(new
            //                              RoleStore<IdentityRole>(context));
            ////Create Admin Role
            //if (!context.Roles.Any(r => r.Name == "Admin"))
            //{
            //    var roleresult = roleManager.Create(new IdentityRole("Admin"));
            //}

            ////Create Staff Roles
            //if (!context.Roles.Any(r => r.Name == "Leadership"))
            //{
            //    var roleresult = roleManager.Create(new IdentityRole("Leadership"));
            //}
            //if (!context.Roles.Any(r => r.Name == "Staff_Admin"))
            //{
            //    var roleresult = roleManager.Create(new IdentityRole("Staff_Admin"));
            //}
            //if (!context.Roles.Any(r => r.Name == "Community"))
            //{
            //    var roleresult = roleManager.Create(new IdentityRole("Community"));
            //}
            //if (!context.Roles.Any(r => r.Name == "Outreach"))
            //{
            //    var roleresult = roleManager.Create(new IdentityRole("Outreach"));
            //}
            //if (!context.Roles.Any(r => r.Name == "Residential"))
            //{
            //    var roleresult = roleManager.Create(new IdentityRole("Residential"));
            //}
            //if (!context.Roles.Any(r => r.Name == "New Staff"))
            //{
            //    var roleresult = roleManager.Create(new IdentityRole("New Staff"));
            //}

            ////Create Board Roles
            //if (!context.Roles.Any(r => r.Name == "Audit_Finance"))
            //{
            //    var roleresult = roleManager.Create(new IdentityRole("Audit_Finance"));
            //}
            //if (!context.Roles.Any(r => r.Name == "Community_Relations"))
            //{
            //    var roleresult = roleManager.Create(new IdentityRole("Community_Relations"));
            //}
            //if (!context.Roles.Any(r => r.Name == "Governance_Committee"))
            //{
            //    var roleresult = roleManager.Create(new IdentityRole("Governance_Committee"));
            //}
            //if (!context.Roles.Any(r => r.Name == "Operations"))
            //{
            //    var roleresult = roleManager.Create(new IdentityRole("Operations"));
            //}
            //if (!context.Roles.Any(r => r.Name == "New_Board"))
            //{
            //    var roleresult = roleManager.Create(new IdentityRole("New_Board"));
            //}

            ////Create Voluneteer Roles
            //if (!context.Roles.Any(r => r.Name == "Bereavement"))
            //{
            //    var roleresult = roleManager.Create(new IdentityRole("Bereavement"));
            //}
            //if (!context.Roles.Any(r => r.Name == "Community"))
            //{
            //    var roleresult = roleManager.Create(new IdentityRole("Community"));
            //}
            //if (!context.Roles.Any(r => r.Name == "Day_Hospice"))
            //{
            //    var roleresult = roleManager.Create(new IdentityRole("Day_Hospice"));
            //}
            //if (!context.Roles.Any(r => r.Name == "Residential"))
            //{
            //    var roleresult = roleManager.Create(new IdentityRole("Residential"));
            //}
            //if (!context.Roles.Any(r => r.Name == "Welcome_Desk"))
            //{
            //    var roleresult = roleManager.Create(new IdentityRole("Welcome_Desk"));
            //}
            //if (!context.Roles.Any(r => r.Name == "Event_Non-Client"))
            //{
            //    var roleresult = roleManager.Create(new IdentityRole("Event_Non-Client"));
            //}
            //if (!context.Roles.Any(r => r.Name == "Admin_Non-Client"))
            //{
            //    var roleresult = roleManager.Create(new IdentityRole("Admin_Non-Client"));
            //}
            //if (!context.Roles.Any(r => r.Name == "New_Volunteers"))
            //{
            //    var roleresult = roleManager.Create(new IdentityRole("New_Volunteers"));
            //}

            ////Create a few generic users
            //var manager = new UserManager<ApplicationUser>(
            //    new UserStore<ApplicationUser>(context));

            //var admin = new ApplicationUser
            //{
            //    UserName = string.Format("admin@outlook.com"),
            //    Email = string.Format("admin@outlook.com")
            //};
            //if (!context.Users.Any(u => u.UserName == admin.UserName))
            //{
            //    manager.Create(admin, "Password1!");
            //    manager.AddToRole(admin.Id, "Admin");
            //}

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
