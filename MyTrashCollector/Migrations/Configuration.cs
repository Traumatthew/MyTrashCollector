namespace MyTrashCollector.Migrations
{
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<MyTrashCollector.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(MyTrashCollector.Models.ApplicationDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.

            //var customerRole = new IdentityRole("Customer");
            //context.Roles.Add(customerRole);

            //var employeeRole = new IdentityRole("Employee");
            //context.Roles.Add(employeeRole);

            context.Roles.AddOrUpdate(r => r.Name,
                new IdentityRole() { Name = "Customer" },
                new IdentityRole() { Name = "Employee" }
             );

            //var roleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(context));
            //string[] roleNames = { "Customer", "Employee" };
            //IdentityResult roleResult;
            //foreach (var roleName in roleNames)
            //{
            //    if (!roleManager.RoleExists(roleName))
            //    {
            //        roleResult = roleManager.Create(new IdentityRole(roleName));
            //    }
            //}

            
        }
    }
}
