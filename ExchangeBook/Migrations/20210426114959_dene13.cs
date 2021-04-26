using Microsoft.EntityFrameworkCore.Migrations;

namespace ExchangeBook.Migrations
{
    public partial class dene13 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MyBooks_BookTypes_BookTypeTypeId",
                table: "MyBooks");

            migrationBuilder.DropIndex(
                name: "IX_MyBooks_BookTypeTypeId",
                table: "MyBooks");

            migrationBuilder.DropColumn(
                name: "BookTypeTypeId",
                table: "MyBooks");

            migrationBuilder.DropColumn(
                name: "TypeName",
                table: "MyBooks");

            migrationBuilder.AddColumn<int>(
                name: "TypeId",
                table: "MyBooks",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_MyBooks_TypeId",
                table: "MyBooks",
                column: "TypeId");

          
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MyBooks_BookTypes_TypeId",
                table: "MyBooks");

            migrationBuilder.DropIndex(
                name: "IX_MyBooks_TypeId",
                table: "MyBooks");

            migrationBuilder.DropColumn(
                name: "TypeId",
                table: "MyBooks");

            migrationBuilder.AddColumn<int>(
                name: "BookTypeTypeId",
                table: "MyBooks",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TypeName",
                table: "MyBooks",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_MyBooks_BookTypeTypeId",
                table: "MyBooks",
                column: "BookTypeTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_MyBooks_BookTypes_BookTypeTypeId",
                table: "MyBooks",
                column: "BookTypeTypeId",
                principalTable: "BookTypes",
                principalColumn: "TypeId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
