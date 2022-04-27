using Microsoft.EntityFrameworkCore.Migrations;

namespace BookShop.Migrations
{
    public partial class mig8p79996362 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Translator_Book_BookInfo_BookId",
                table: "Translator_Book");

            migrationBuilder.DropForeignKey(
                name: "FK_Translator_Book_TranslatorInfo_translatorId",
                table: "Translator_Book");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Translator_Book",
                table: "Translator_Book");

            migrationBuilder.RenameTable(
                name: "Translator_Book",
                newName: "translator_Books");

            migrationBuilder.RenameIndex(
                name: "IX_Translator_Book_translatorId",
                table: "translator_Books",
                newName: "IX_translator_Books_translatorId");

            migrationBuilder.RenameIndex(
                name: "IX_Translator_Book_BookId",
                table: "translator_Books",
                newName: "IX_translator_Books_BookId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_translator_Books",
                table: "translator_Books",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_translator_Books_BookInfo_BookId",
                table: "translator_Books",
                column: "BookId",
                principalTable: "BookInfo",
                principalColumn: "BookId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_translator_Books_TranslatorInfo_translatorId",
                table: "translator_Books",
                column: "translatorId",
                principalTable: "TranslatorInfo",
                principalColumn: "Translator_Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_translator_Books_BookInfo_BookId",
                table: "translator_Books");

            migrationBuilder.DropForeignKey(
                name: "FK_translator_Books_TranslatorInfo_translatorId",
                table: "translator_Books");

            migrationBuilder.DropPrimaryKey(
                name: "PK_translator_Books",
                table: "translator_Books");

            migrationBuilder.RenameTable(
                name: "translator_Books",
                newName: "Translator_Book");

            migrationBuilder.RenameIndex(
                name: "IX_translator_Books_translatorId",
                table: "Translator_Book",
                newName: "IX_Translator_Book_translatorId");

            migrationBuilder.RenameIndex(
                name: "IX_translator_Books_BookId",
                table: "Translator_Book",
                newName: "IX_Translator_Book_BookId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Translator_Book",
                table: "Translator_Book",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Translator_Book_BookInfo_BookId",
                table: "Translator_Book",
                column: "BookId",
                principalTable: "BookInfo",
                principalColumn: "BookId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Translator_Book_TranslatorInfo_translatorId",
                table: "Translator_Book",
                column: "translatorId",
                principalTable: "TranslatorInfo",
                principalColumn: "Translator_Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
