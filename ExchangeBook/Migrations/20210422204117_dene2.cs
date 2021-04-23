using Microsoft.EntityFrameworkCore.Migrations;

namespace ExchangeBook.Migrations
{
    public partial class dene2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Opinions_MyBooks_MyBookBookId",
                table: "Opinions");

            migrationBuilder.DropIndex(
                name: "IX_Opinions_MyBookBookId",
                table: "Opinions");

            migrationBuilder.DropColumn(
                name: "MyBookBookId",
                table: "Opinions");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "MyBookBookId",
                table: "Opinions",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Opinions_MyBookBookId",
                table: "Opinions",
                column: "MyBookBookId");

            migrationBuilder.AddForeignKey(
                name: "FK_Opinions_MyBooks_MyBookBookId",
                table: "Opinions",
                column: "MyBookBookId",
                principalTable: "MyBooks",
                principalColumn: "BookId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
