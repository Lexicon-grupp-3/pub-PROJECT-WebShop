using Microsoft.EntityFrameworkCore.Migrations;

namespace WebShopReactCore.Data.Migrations
{
    public partial class changedconnectinoStringIdentity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "98fca519-6055-49e9-b7f1-12b33be3bd7c", "98fca519-6055-49e9-b7f1-12b33be3bd7c", "admin", "ADMIN" },
                    { "e88ee25c-5b12-4c13-849b-1569ebab42b0", "e88ee25c-5b12-4c13-849b-1569ebab42b0", "user", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "b8e0e29a-64b9-4aef-a067-438c343e0aed", 0, "98fca519-6055-49e9-b7f1-12b33be3bd7c", "admin@data4mat.com", true, "admin", "admin", false, null, "ADMIN@DATA4MAT.COM", "ADMIN@DATA4MAT.COM", "AQAAAAEAACcQAAAAECooRKvXd5aF0zW+hTD8NOsg9pcSIK8h5nghwviYH35ly9KtD401vLCbMLSXWZTOlw==", null, false, "98fca519-6055-49e9-b7f1-12b33be3bd7c", false, "admin@data4mat.com" },
                    { "08dba50d-0ed9-4488-a7bb-f0d2f938fc42", 0, "e88ee25c-5b12-4c13-849b-1569ebab42b0", "chris@data4mat.com", true, "Chris", "Johannesson", false, null, "CHRIS@DATA4MAT.COM", "CHRIS@DATA4MAT.COM", "AQAAAAEAACcQAAAAEOCePx1faNa2+UE0CtLky6NT/dZjc57FCE5ItIk048ZOknvm3c2m44ruvLhdt2i7gw==", null, false, "e88ee25c-5b12-4c13-849b-1569ebab42b0", false, "chris@data4mat.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "98fca519-6055-49e9-b7f1-12b33be3bd7c", "b8e0e29a-64b9-4aef-a067-438c343e0aed" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "e88ee25c-5b12-4c13-849b-1569ebab42b0", "08dba50d-0ed9-4488-a7bb-f0d2f938fc42" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "e88ee25c-5b12-4c13-849b-1569ebab42b0", "08dba50d-0ed9-4488-a7bb-f0d2f938fc42" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "98fca519-6055-49e9-b7f1-12b33be3bd7c", "b8e0e29a-64b9-4aef-a067-438c343e0aed" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "98fca519-6055-49e9-b7f1-12b33be3bd7c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e88ee25c-5b12-4c13-849b-1569ebab42b0");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "08dba50d-0ed9-4488-a7bb-f0d2f938fc42");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b8e0e29a-64b9-4aef-a067-438c343e0aed");

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
    }
}
