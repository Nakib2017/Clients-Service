using ClientsList.Models;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace ClientsList.DAL
{
 
        public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
        {
            public ApplicationDbContext()
                : base("ApplicationDbContext")
            {
            }

            public static ApplicationDbContext Create()
            {
                return new ApplicationDbContext();
            }



        }

        public class ClientContext : DbContext
        {

            public ClientContext()
                : base("ApplicationDbContext")
            {
                Database.SetInitializer<ClientContext>
              (new DropCreateDatabaseIfModelChanges<ClientContext>());
            }


            public DbSet<Cleint> Cleints { get; set; }


        public DbSet<Employee> Employees { get; set; }






        protected override void OnModelCreating(DbModelBuilder modelBuilder)
            {
                modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            }


        }
    }
