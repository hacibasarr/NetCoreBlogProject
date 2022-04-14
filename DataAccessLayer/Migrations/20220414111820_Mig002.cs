using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class Mig002 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CategoryCtegoryID",
                table: "Blogs",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Blogs_CategoryCtegoryID",
                table: "Blogs",
                column: "CategoryCtegoryID");

            migrationBuilder.AddForeignKey(
                name: "FK_Blogs_Categories_CategoryCtegoryID",
                table: "Blogs",
                column: "CategoryCtegoryID",
                principalTable: "Categories",
                principalColumn: "CtegoryID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Blogs_Categories_CategoryCtegoryID",
                table: "Blogs");

            migrationBuilder.DropIndex(
                name: "IX_Blogs_CategoryCtegoryID",
                table: "Blogs");

            migrationBuilder.DropColumn(
                name: "CategoryCtegoryID",
                table: "Blogs");
        }
    }
}
