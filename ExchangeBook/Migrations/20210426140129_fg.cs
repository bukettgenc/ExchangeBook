using Microsoft.EntityFrameworkCore.Migrations;

namespace ExchangeBook.Migrations
{
    public partial class fg : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "City",
                table: "MyBooks",
                newName: "CityId");

            migrationBuilder.AddColumn<int>(
                name: "CityId1",
                table: "MyBooks",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_MyBooks_CityId1",
                table: "MyBooks",
                column: "CityId1");

            migrationBuilder.AddForeignKey(
                name: "FK_MyBooks_Cities_CityId1",
                table: "MyBooks",
                column: "CityId1",
                principalTable: "Cities",
                principalColumn: "CityId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MyBooks_Cities_CityId1",
                table: "MyBooks");

            migrationBuilder.DropIndex(
                name: "IX_MyBooks_CityId1",
                table: "MyBooks");

            migrationBuilder.DropColumn(
                name: "CityId1",
                table: "MyBooks");

            migrationBuilder.RenameColumn(
                name: "CityId",
                table: "MyBooks",
                newName: "City");
        }
    }
}
