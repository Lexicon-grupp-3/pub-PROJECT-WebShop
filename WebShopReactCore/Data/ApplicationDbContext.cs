using IdentityServer4.EntityFramework.Options;
using Microsoft.AspNetCore.ApiAuthorization.IdentityServer;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebShopReactCore.Models;

namespace WebShopReactCore.Data
{
    public class ApplicationDbContext : ApiAuthorizationDbContext<ApplicationUser>
    {
        public ApplicationDbContext(
            DbContextOptions<ApplicationDbContext> options,
            IOptions<OperationalStoreOptions> operationalStoreOptions) : base(options, operationalStoreOptions)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);


            

            string adminRoleId = Guid.NewGuid().ToString();
            string userRoleId = Guid.NewGuid().ToString();
            string user2RoleId = Guid.NewGuid().ToString();
            string adminId = Guid.NewGuid().ToString();
            string userId = Guid.NewGuid().ToString();
            string userId2 = Guid.NewGuid().ToString();

            builder.Entity<IdentityRole>().HasData(
                new IdentityRole
                {
                    Id = adminRoleId,
                    Name = "admin",
                    NormalizedName = "ADMIN",
                    ConcurrencyStamp = adminRoleId
                },
                new IdentityRole
                {
                    Id = userRoleId,
                    Name = "user",
                    NormalizedName = "USER",
                    ConcurrencyStamp = userRoleId
                },
                new IdentityRole
                {
                    Id = user2RoleId,
                    Name = "user",
                    NormalizedName = "USER",
                    ConcurrencyStamp = user2RoleId
                });

            PasswordHasher<ApplicationUser> passwordHasher = new PasswordHasher<ApplicationUser>();
            var AdminUser = new ApplicationUser
            {
                Id = adminId,
                FirstName = "admin",
                LastName = "admin",
                Email = "admin@data4mat.com",
                NormalizedEmail = "ADMIN@DATA4MAT.COM",
                EmailConfirmed = true,
                UserName = "admin@data4mat.com",
                NormalizedUserName = "ADMIN@DATA4MAT.COM",
                ConcurrencyStamp = adminRoleId,
                SecurityStamp = adminRoleId
            };


            var SiteUser = new ApplicationUser
            {
                Id = userId,
                FirstName = "Chris",
                LastName = "Johannesson",
                Email = "chris@data4mat.com",
                NormalizedEmail = "CHRIS@DATA4MAT.COM",
                EmailConfirmed = true,
                UserName = "chris@data4mat.com",
                NormalizedUserName = "CHRIS@DATA4MAT.COM",
                ConcurrencyStamp = userRoleId,
                SecurityStamp = userRoleId
            };

            var SiteUser2 = new ApplicationUser
            {
                Id = userId2,
                FirstName = "ÅäöÖÖ",
                LastName = "Jönssånäs",
                Email = "chris2@data4mat.com",
                NormalizedEmail = "CHRIS2@DATA4MAT.COM",
                EmailConfirmed = true,
                UserName = "chris2@data4mat.com",
                NormalizedUserName = "CHRIS2@DATA4MAT.COM",
                ConcurrencyStamp = user2RoleId,
                SecurityStamp = user2RoleId
            };


            AdminUser.PasswordHash = passwordHasher.HashPassword(AdminUser, "admin");
            builder.Entity<ApplicationUser>().HasData(AdminUser);
            builder.Entity<IdentityUserRole<string>>().HasData(
                new IdentityUserRole<string>
                {
                    RoleId = adminRoleId,
                    UserId = adminId
                });

            SiteUser.PasswordHash = passwordHasher.HashPassword(SiteUser, "1234");
            builder.Entity<ApplicationUser>().HasData(SiteUser);
            builder.Entity<IdentityUserRole<string>>().HasData(
                new IdentityUserRole<string>
                {
                    RoleId = userRoleId,
                    UserId = userId
                });

            SiteUser.PasswordHash = passwordHasher.HashPassword(SiteUser2, "1234");
            builder.Entity<ApplicationUser>().HasData(SiteUser2);
            builder.Entity<IdentityUserRole<string>>().HasData(
                new IdentityUserRole<string>
                {
                    RoleId = userRoleId,
                    UserId = userId2
                });
        }
    }
}
