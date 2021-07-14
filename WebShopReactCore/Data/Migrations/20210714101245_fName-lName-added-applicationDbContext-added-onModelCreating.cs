using Microsoft.EntityFrameworkCore.Migrations;

namespace WebShopReactCore.Data.Migrations
{
    public partial class fNamelNameaddedapplicationDbContextaddedonModelCreating : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "351e8f3e-a13d-4748-ae8d-e7de7e9a2550", "351e8f3e-a13d-4748-ae8d-e7de7e9a2550", "admin", "ADMIN" },
                    { "84639310-433b-455d-a7fc-1ab350d367ba", "84639310-433b-455d-a7fc-1ab350d367ba", "user", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "7e0daa1c-a45c-4ab3-80fd-828e96e282c7", 0, "351e8f3e-a13d-4748-ae8d-e7de7e9a2550", "admin@data4mat.com", true, "admin", "admin", false, null, "ADMIN@DATA4MAT.COM", "ADMIN@DATA4MAT.COM", "AQAAAAEAACcQAAAAEFrYnm6HWfML81a+/A3WtzL/upcCWkgkX1rdwqfZh6zeaelOGPYPBj3shfS+bv/G/w==", null, false, "351e8f3e-a13d-4748-ae8d-e7de7e9a2550", false, "admin@data4mat.com" },
                    { "4537ad5a-f308-4fe8-a6f1-04cc35736cc1", 0, "84639310-433b-455d-a7fc-1ab350d367ba", "chris@data4mat.com", true, "Chris", "Johannesson", false, null, "CHRIS@DATA4MAT.COM", "CHRIS@DATA4MAT.COM", "AQAAAAEAACcQAAAAEB9KscIFxj44Jx0AeST6VVuJGAVxPLQqQ1jGMbZQRpwUKPX7N86L/DPM6M4bkelz+w==", null, false, "84639310-433b-455d-a7fc-1ab350d367ba", false, "chris@data4mat.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "351e8f3e-a13d-4748-ae8d-e7de7e9a2550", "7e0daa1c-a45c-4ab3-80fd-828e96e282c7" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "84639310-433b-455d-a7fc-1ab350d367ba", "4537ad5a-f308-4fe8-a6f1-04cc35736cc1" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "84639310-433b-455d-a7fc-1ab350d367ba", "4537ad5a-f308-4fe8-a6f1-04cc35736cc1" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "351e8f3e-a13d-4748-ae8d-e7de7e9a2550", "7e0daa1c-a45c-4ab3-80fd-828e96e282c7" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "351e8f3e-a13d-4748-ae8d-e7de7e9a2550");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "84639310-433b-455d-a7fc-1ab350d367ba");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4537ad5a-f308-4fe8-a6f1-04cc35736cc1");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7e0daa1c-a45c-4ab3-80fd-828e96e282c7");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "AspNetUsers");
        }
    }
}
