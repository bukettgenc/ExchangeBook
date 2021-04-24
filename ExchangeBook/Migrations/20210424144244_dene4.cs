using Microsoft.EntityFrameworkCore.Migrations;

namespace ExchangeBook.Migrations
{
    public partial class dene4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "BookExplanation",
                table: "MyBooks",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BookExplanation",
                table: "MyBooks");
        }
    }
}
