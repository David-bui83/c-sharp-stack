using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace chef.Migrations
{
    public partial class chefDsihes2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "DOB",
                table: "Chefs",
                nullable: false,
                oldClrType: typeof(string));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "DOB",
                table: "Chefs",
                nullable: false,
                oldClrType: typeof(DateTime));
        }
    }
}
