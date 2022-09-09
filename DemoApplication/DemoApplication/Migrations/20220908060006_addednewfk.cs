using Microsoft.EntityFrameworkCore.Migrations;

namespace DemoApplication.Migrations
{
    public partial class addednewfk : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BookGallery_Books_BooksID",
                table: "BookGallery");

            migrationBuilder.DropIndex(
                name: "IX_BookGallery_BooksID",
                table: "BookGallery");

            migrationBuilder.DropColumn(
                name: "BooksID",
                table: "BookGallery");

            migrationBuilder.CreateIndex(
                name: "IX_BookGallery_BookID",
                table: "BookGallery",
                column: "BookID");

            migrationBuilder.AddForeignKey(
                name: "FK_BookGallery_Books_BookID",
                table: "BookGallery",
                column: "BookID",
                principalTable: "Books",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BookGallery_Books_BookID",
                table: "BookGallery");

            migrationBuilder.DropIndex(
                name: "IX_BookGallery_BookID",
                table: "BookGallery");

            migrationBuilder.AddColumn<int>(
                name: "BooksID",
                table: "BookGallery",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_BookGallery_BooksID",
                table: "BookGallery",
                column: "BooksID");

            migrationBuilder.AddForeignKey(
                name: "FK_BookGallery_Books_BooksID",
                table: "BookGallery",
                column: "BooksID",
                principalTable: "Books",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
