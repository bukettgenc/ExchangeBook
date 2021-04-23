using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ExchangeBook.Migrations
{
    public partial class dene : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Opinions",
                columns: table => new
                {
                    OpinionId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    YourOpinion = table.Column<string>(nullable: true),
                    UserId = table.Column<int>(nullable: false),
                    MyBookBookId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Opinions", x => x.OpinionId);
                    table.ForeignKey(
                        name: "FK_Opinions_MyBooks_MyBookBookId",
                        column: x => x.MyBookBookId,
                        principalTable: "MyBooks",
                        principalColumn: "BookId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Opinions_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Opinions_MyBookBookId",
                table: "Opinions",
                column: "MyBookBookId");

            migrationBuilder.CreateIndex(
                name: "IX_Opinions_UserId",
                table: "Opinions",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Opinions");
        }
    }
}
