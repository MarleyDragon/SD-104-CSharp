using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Game.Data.Migrations
{
    public partial class four : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "DateOfBirth",
                table: "Gamer",
                nullable: false,
                oldClrType: typeof(int));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "DateOfBirth",
                table: "Gamer",
                nullable: false,
                oldClrType: typeof(DateTime));
        }
    }
}
