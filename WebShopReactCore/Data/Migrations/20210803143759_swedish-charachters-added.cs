using Microsoft.EntityFrameworkCore.Migrations;

namespace WebShopReactCore.Data.Migrations
{
    public partial class swedishcharachtersadded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "dfef2abc-d1f8-46aa-812a-495b6957752a", "cfa2fec1-484c-4f2e-b043-d301ced97434" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "e9208af7-4c0e-4fa0-9665-eed3a60679e0", "d1b89678-c2bc-4675-a159-50b37fcf7c22" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "dfef2abc-d1f8-46aa-812a-495b6957752a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e9208af7-4c0e-4fa0-9665-eed3a60679e0");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cfa2fec1-484c-4f2e-b043-d301ced97434");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d1b89678-c2bc-4675-a159-50b37fcf7c22");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "433177c4-b201-45db-aa5d-07550b674b41", "433177c4-b201-45db-aa5d-07550b674b41", "admin", "ADMIN" },
                    { "8632cc42-9eab-4b86-ad09-f850333976e2", "8632cc42-9eab-4b86-ad09-f850333976e2", "user", "USER" },
                    { "00bc6f99-2a41-49c3-abe2-60e5da4453b7", "00bc6f99-2a41-49c3-abe2-60e5da4453b7", "user", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "d7639527-6c3c-4f1c-8e38-bab127c309e9", 0, "433177c4-b201-45db-aa5d-07550b674b41", "admin@data4mat.com", true, "admin", "admin", false, null, "ADMIN@DATA4MAT.COM", "ADMIN@DATA4MAT.COM", "AQAAAAEAACcQAAAAEGE649GIhfstJu586eDIKsGcHnoL50AzCR97gzHB+rxtA5CuprULyMqUx8d2cc+HRQ==", null, false, "433177c4-b201-45db-aa5d-07550b674b41", false, "admin@data4mat.com" },
                    { "7a3b1fe4-c00f-447c-a135-ce3f682e7cad", 0, "8632cc42-9eab-4b86-ad09-f850333976e2", "chris@data4mat.com", true, "Chris", "Johannesson", false, null, "CHRIS@DATA4MAT.COM", "CHRIS@DATA4MAT.COM", "AQAAAAEAACcQAAAAEJg0eHFwKTNz7DvezW3vR0dIoPPHhw/XdtyW+9jTuEXZwXM2gWK2Ay2U5OtF4dBlsg==", null, false, "8632cc42-9eab-4b86-ad09-f850333976e2", false, "chris@data4mat.com" },
                    { "c16f9017-3c48-4aeb-87e3-916b7c659f27", 0, "00bc6f99-2a41-49c3-abe2-60e5da4453b7", "chris2@data4mat.com", true, "ÅäöÖÖ", "Jönssånäs", false, null, "CHRIS2@DATA4MAT.COM", "CHRIS2@DATA4MAT.COM", null, null, false, "00bc6f99-2a41-49c3-abe2-60e5da4453b7", false, "chris2@data4mat.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "433177c4-b201-45db-aa5d-07550b674b41", "d7639527-6c3c-4f1c-8e38-bab127c309e9" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "8632cc42-9eab-4b86-ad09-f850333976e2", "7a3b1fe4-c00f-447c-a135-ce3f682e7cad" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "8632cc42-9eab-4b86-ad09-f850333976e2", "c16f9017-3c48-4aeb-87e3-916b7c659f27" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "00bc6f99-2a41-49c3-abe2-60e5da4453b7");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "8632cc42-9eab-4b86-ad09-f850333976e2", "7a3b1fe4-c00f-447c-a135-ce3f682e7cad" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "8632cc42-9eab-4b86-ad09-f850333976e2", "c16f9017-3c48-4aeb-87e3-916b7c659f27" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "433177c4-b201-45db-aa5d-07550b674b41", "d7639527-6c3c-4f1c-8e38-bab127c309e9" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "433177c4-b201-45db-aa5d-07550b674b41");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8632cc42-9eab-4b86-ad09-f850333976e2");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7a3b1fe4-c00f-447c-a135-ce3f682e7cad");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c16f9017-3c48-4aeb-87e3-916b7c659f27");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d7639527-6c3c-4f1c-8e38-bab127c309e9");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "dfef2abc-d1f8-46aa-812a-495b6957752a", "dfef2abc-d1f8-46aa-812a-495b6957752a", "admin", "ADMIN" },
                    { "e9208af7-4c0e-4fa0-9665-eed3a60679e0", "e9208af7-4c0e-4fa0-9665-eed3a60679e0", "user", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "cfa2fec1-484c-4f2e-b043-d301ced97434", 0, "dfef2abc-d1f8-46aa-812a-495b6957752a", "admin@data4mat.com", true, "admin", "admin", false, null, "ADMIN@DATA4MAT.COM", "ADMIN@DATA4MAT.COM", "AQAAAAEAACcQAAAAEKIZlFqA+/V4B2/axQqiuPCev9u0MRdtH2iPOhJstX/NOQAM2DfqIACSbXz7PCjzpA==", null, false, "dfef2abc-d1f8-46aa-812a-495b6957752a", false, "admin@data4mat.com" },
                    { "d1b89678-c2bc-4675-a159-50b37fcf7c22", 0, "e9208af7-4c0e-4fa0-9665-eed3a60679e0", "chris@data4mat.com", true, "Chris", "Johannesson", false, null, "CHRIS@DATA4MAT.COM", "CHRIS@DATA4MAT.COM", "AQAAAAEAACcQAAAAECh/zHF+zeriztQoWFDE9IDDSxtKj4+nig4Ri3zY/Qn039zAFrfIG0idM2ms3LgV4w==", null, false, "e9208af7-4c0e-4fa0-9665-eed3a60679e0", false, "chris@data4mat.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "dfef2abc-d1f8-46aa-812a-495b6957752a", "cfa2fec1-484c-4f2e-b043-d301ced97434" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "e9208af7-4c0e-4fa0-9665-eed3a60679e0", "d1b89678-c2bc-4675-a159-50b37fcf7c22" });
        }
    }
}
