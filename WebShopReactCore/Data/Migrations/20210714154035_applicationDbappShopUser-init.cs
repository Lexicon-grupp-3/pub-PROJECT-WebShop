using Microsoft.EntityFrameworkCore.Migrations;

namespace WebShopReactCore.Data.Migrations
{
    public partial class applicationDbappShopUserinit : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
