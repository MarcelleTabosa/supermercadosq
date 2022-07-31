using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace supermercadosq.Migrations
{
    public partial class CorrectionCreateUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "MyProperty",
                table: "Users",
                newName: "Level");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Level",
                table: "Users",
                newName: "MyProperty");
        }
    }
}
