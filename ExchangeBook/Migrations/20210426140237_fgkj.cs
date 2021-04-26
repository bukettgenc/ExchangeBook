using Microsoft.EntityFrameworkCore.Migrations;

namespace ExchangeBook.Migrations
{
    public partial class fgkj : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AlterColumn<int>(
                name: "CityId",
                table: "MyBooks",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_MyBooks_CityId",
                table: "MyBooks",
                column: "CityId");

            //migrationBuilder.AddForeignKey(
            //    name: "FK_MyBooks_Cities_CityId",
            //    table: "MyBooks",
            //    column: "CityId",
            //    principalTable: "Cities",
            //    principalColumn: "CityId",
            //    onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MyBooks_Cities_CityId",
                table: "MyBooks");

            migrationBuilder.DropIndex(
                name: "IX_MyBooks_CityId",
                table: "MyBooks");

            migrationBuilder.AlterColumn<string>(
                name: "CityId",
                table: "MyBooks",
                nullable: true,
                oldClrType: typeof(int));

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
    }
}
