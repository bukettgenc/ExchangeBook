using Microsoft.EntityFrameworkCore.Migrations;

namespace ExchangeBook.Migrations
{
    public partial class dene8 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AlterColumn<string>(
                name: "UserName",
                table: "Users",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Surname",
                table: "Users",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Password2",
                table: "Users",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Password",
                table: "Users",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Users",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "YourOpinion",
                table: "Opinions",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "BookName",
                table: "MyBooks",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "BookAuthor",
                table: "MyBooks",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "BookTypeTypeId",
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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AlterColumn<string>(
                name: "UserName",
                table: "Users",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "Surname",
                table: "Users",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "Password2",
                table: "Users",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "Password",
                table: "Users",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Users",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "YourOpinion",
                table: "Opinions",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "BookName",
                table: "MyBooks",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "BookAuthor",
                table: "MyBooks",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AddColumn<int>(
                name: "TypeId",
                table: "MyBooks",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_MyBooks_TypeId",
                table: "MyBooks",
                column: "TypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_MyBooks_BookTypes_TypeId",
                table: "MyBooks",
                column: "TypeId",
                principalTable: "BookTypes",
                principalColumn: "TypeId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
