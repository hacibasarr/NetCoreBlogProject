using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class Mig004 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Blogs_Categories_CategoryCtegoryID",
                table: "Blogs");

            migrationBuilder.RenameColumn(
                name: "CtegoryID",
                table: "Categories",
                newName: "CategoryID");

            migrationBuilder.RenameColumn(
                name: "CategoryCtegoryID",
                table: "Blogs",
                newName: "CategoryID");

            migrationBuilder.RenameIndex(
                name: "IX_Blogs_CategoryCtegoryID",
                table: "Blogs",
                newName: "IX_Blogs_CategoryID");

            migrationBuilder.AddForeignKey(
                name: "FK_Blogs_Categories_CategoryID",
                table: "Blogs",
                column: "CategoryID",
                principalTable: "Categories",
                principalColumn: "CategoryID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Blogs_Categories_CategoryID",
                table: "Blogs");

            migrationBuilder.RenameColumn(
                name: "CategoryID",
                table: "Categories",
                newName: "CtegoryID");

            migrationBuilder.RenameColumn(
                name: "CategoryID",
                table: "Blogs",
                newName: "CategoryCtegoryID");

            migrationBuilder.RenameIndex(
                name: "IX_Blogs_CategoryID",
                table: "Blogs",
                newName: "IX_Blogs_CategoryCtegoryID");

            migrationBuilder.AddForeignKey(
                name: "FK_Blogs_Categories_CategoryCtegoryID",
                table: "Blogs",
                column: "CategoryCtegoryID",
                principalTable: "Categories",
                principalColumn: "CtegoryID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
