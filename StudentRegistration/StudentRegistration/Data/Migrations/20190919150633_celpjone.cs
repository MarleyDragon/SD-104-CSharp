using Microsoft.EntityFrameworkCore.Migrations;

namespace StudentRegistration.Data.Migrations
{
    public partial class celpjone : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "CellPhone",
                table: "Student",
                nullable: true,
                oldClrType: typeof(int));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "CellPhone",
                table: "Student",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }
    }
}
