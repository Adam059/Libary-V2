using Microsoft.EntityFrameworkCore.Migrations;

namespace Library.Web.Migrations
{
    public partial class AddBookLendings2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BookLending_Books_BookId",
                table: "BookLending");

            migrationBuilder.DropForeignKey(
                name: "FK_BookLending_Users_OwnerId",
                table: "BookLending");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BookLending",
                table: "BookLending");

            migrationBuilder.RenameTable(
                name: "BookLending",
                newName: "BookLendings");

            migrationBuilder.RenameIndex(
                name: "IX_BookLending_OwnerId",
                table: "BookLendings",
                newName: "IX_BookLendings_OwnerId");

            migrationBuilder.RenameIndex(
                name: "IX_BookLending_BookId",
                table: "BookLendings",
                newName: "IX_BookLendings_BookId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BookLendings",
                table: "BookLendings",
                column: "BookLendingId");

            migrationBuilder.AddForeignKey(
                name: "FK_BookLendings_Books_BookId",
                table: "BookLendings",
                column: "BookId",
                principalTable: "Books",
                principalColumn: "BookId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BookLendings_Users_OwnerId",
                table: "BookLendings",
                column: "OwnerId",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BookLendings_Books_BookId",
                table: "BookLendings");

            migrationBuilder.DropForeignKey(
                name: "FK_BookLendings_Users_OwnerId",
                table: "BookLendings");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BookLendings",
                table: "BookLendings");

            migrationBuilder.RenameTable(
                name: "BookLendings",
                newName: "BookLending");

            migrationBuilder.RenameIndex(
                name: "IX_BookLendings_OwnerId",
                table: "BookLending",
                newName: "IX_BookLending_OwnerId");

            migrationBuilder.RenameIndex(
                name: "IX_BookLendings_BookId",
                table: "BookLending",
                newName: "IX_BookLending_BookId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BookLending",
                table: "BookLending",
                column: "BookLendingId");

            migrationBuilder.AddForeignKey(
                name: "FK_BookLending_Books_BookId",
                table: "BookLending",
                column: "BookId",
                principalTable: "Books",
                principalColumn: "BookId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BookLending_Users_OwnerId",
                table: "BookLending",
                column: "OwnerId",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
