using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebShopReactCore.Migrations
{
    public partial class newOrder : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreateDateTime",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "UpdateDateTime",
                table: "Orders");

            migrationBuilder.AddColumn<string>(
                name: "userEmail",
                table: "Orders",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "userEmail",
                table: "Orders");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreateDateTime",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdateDateTime",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 5,
                column: "PictureRef",
                value: "/Images/den-vedervärdige-mannen-från-säffle");
        }
    }
}
