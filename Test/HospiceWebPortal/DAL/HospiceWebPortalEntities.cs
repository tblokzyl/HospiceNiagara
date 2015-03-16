using HospiceWebPortal.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace HospiceWebPortal.DAL
{
    public class HospiceWebPortalEntities : DbContext
    {
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
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
        }

        public System.Data.Entity.DbSet<HospiceWebPortal.Models.DeathNotification> DeathNotifications { get; set; }

    }
}