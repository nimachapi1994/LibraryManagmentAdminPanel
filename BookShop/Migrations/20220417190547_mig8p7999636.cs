using Microsoft.EntityFrameworkCore.Migrations;

namespace BookShop.Migrations
{
    public partial class mig8p7999636 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Translator_Book_BookInfo_BookId",
                table: "Translator_Book");

            migrationBuilder.DropForeignKey(
                name: "FK_Translator_Book_TranslatorInfo_translatorIdTranslator_Id",
                table: "Translator_Book");

            migrationBuilder.DropIndex(
                name: "IX_Translator_Book_translatorIdTranslator_Id",
                table: "Translator_Book");

            migrationBuilder.DropColumn(
                name: "translatorIdTranslator_Id",
                table: "Translator_Book");

            migrationBuilder.AlterColumn<int>(
                name: "BookId",
                table: "Translator_Book",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "translatorId",
                table: "Translator_Book",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Translator_Book_translatorId",
                table: "Translator_Book",
                column: "translatorId");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Translator_Book_BookInfo_BookId",
                table: "Translator_Book");

            migrationBuilder.DropForeignKey(
                name: "FK_Translator_Book_TranslatorInfo_translatorId",
                table: "Translator_Book");

            migrationBuilder.DropIndex(
                name: "IX_Translator_Book_translatorId",
                table: "Translator_Book");

            migrationBuilder.DropColumn(
                name: "translatorId",
                table: "Translator_Book");

            migrationBuilder.AlterColumn<int>(
                name: "BookId",
                table: "Translator_Book",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "translatorIdTranslator_Id",
                table: "Translator_Book",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Translator_Book_translatorIdTranslator_Id",
                table: "Translator_Book",
                column: "translatorIdTranslator_Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Translator_Book_BookInfo_BookId",
                table: "Translator_Book",
                column: "BookId",
                principalTable: "BookInfo",
                principalColumn: "BookId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Translator_Book_TranslatorInfo_translatorIdTranslator_Id",
                table: "Translator_Book",
                column: "translatorIdTranslator_Id",
                principalTable: "TranslatorInfo",
                principalColumn: "Translator_Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
