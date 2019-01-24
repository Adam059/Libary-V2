using Microsoft.EntityFrameworkCore.Migrations;

namespace Library.Migrations
{
    public partial class RemoveIsActive : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "BookLendings");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "BookLendings",
                nullable: false,
                defaultValue: false);
        }
    }
}
