using Microsoft.EntityFrameworkCore.Migrations;

namespace BookShop.Migrations
{
    public partial class mig8p799963 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Translator_Book",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BookId = table.Column<int>(type: "int", nullable: true),
                    translatorIdTranslator_Id = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Translator_Book", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Translator_Book_BookInfo_BookId",
                        column: x => x.BookId,
                        principalTable: "BookInfo",
                        principalColumn: "BookId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Translator_Book_TranslatorInfo_translatorIdTranslator_Id",
                        column: x => x.translatorIdTranslator_Id,
                        principalTable: "TranslatorInfo",
                        principalColumn: "Translator_Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Translator_Book_BookId",
                table: "Translator_Book",
                column: "BookId");

            migrationBuilder.CreateIndex(
                name: "IX_Translator_Book_translatorIdTranslator_Id",
                table: "Translator_Book",
                column: "translatorIdTranslator_Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Translator_Book");
        }
    }
}
