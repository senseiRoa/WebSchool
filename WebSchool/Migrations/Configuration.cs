namespace WebSchool.Migrations
{
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using WebSchool.Infraestructure;
    using WebSchool.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(ApplicationDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            var manager = new UserManager<IdentityUserModel>(new UserStore<IdentityUserModel>(new ApplicationDbContext()));
            var roleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(new ApplicationDbContext()));
           

            if (roleManager.Roles.Count() == 0)
            {
                roleManager.Create(new IdentityRole {Id= "14884395-3206-4234-a38a-2f0f4f0d704b", Name = "Profesor" });
                roleManager.Create(new IdentityRole {Id= "43c53a51-c8df-46cb-a61b-5cffe6c15612", Name = "Estudiante" });
                roleManager.Create(new IdentityRole {Id= "f713010c-69f6-4867-91c5-581b665c7d3b", Name = "Administrador" });


            }

            if (manager.Users.Count() == 0)

            {
                var user = new IdentityUserModel
                {
                    Id = "BC1E7CCB-2AA1-4A29-B653-3E247EDF022B",
                    UserName = "admin",
                    Email = "admin@hotmail.com",
                    EmailConfirmed = true,
                    BirthDay = DateTime.Now,
                    FirtsName = "Andres",
                    LastName = "Roa"


                };
                manager.Create(user, "Admin308/*");
                var adminUser = manager.FindByName("admin");
               

                manager.AddToRoles(adminUser.Id, new string[] { "Administrador" });
            }

          


            //
        }
    }
}
