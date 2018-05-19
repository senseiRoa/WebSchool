namespace WebSchool.Migrations
{
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using WebSchool.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<WebSchool.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(WebSchool.Models.ApplicationDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            var manager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(new ApplicationDbContext()));
            var roleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(new ApplicationDbContext()));
           

            if (roleManager.Roles.Count() == 0)
            {
                roleManager.Create(new IdentityRole { Name = "Profesor" });
                roleManager.Create(new IdentityRole { Name = "Estudiante" });
                roleManager.Create(new IdentityRole { Name = "Administrador" });


            }

            if (manager.Users.Count() == 0)

            {
                var user = new ApplicationUser
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
