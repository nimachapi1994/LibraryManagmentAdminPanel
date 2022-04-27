using Microsoft.EntityFrameworkCore.Migrations;

namespace BookShop.Migrations
{
    public partial class mig8p79996 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BookInfo_languages_LanguageId",
                table: "BookInfo");

            migrationBuilder.DropIndex(
                name: "IX_BookInfo_LanguageId",
                table: "BookInfo");

            migrationBuilder.DropColumn(
                name: "LanguageId",
                table: "BookInfo");

            migrationBuilder.CreateIndex(
                name: "IX_BookInfo_LangId",
                table: "BookInfo",
                column: "LangId");

            migrationBuilder.AddForeignKey(
                name: "FK_BookInfo_languages_LangId",
                table: "BookInfo",
                column: "LangId",
                principalTable: "languages",
                principalColumn: "LanguageId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BookInfo_languages_LangId",
                table: "BookInfo");

            migrationBuilder.DropIndex(
                name: "IX_BookInfo_LangId",
                table: "BookInfo");

            migrationBuilder.AddColumn<int>(
                name: "LanguageId",
                table: "BookInfo",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_BookInfo_LanguageId",
                table: "BookInfo",
                column: "LanguageId");

            migrationBuilder.AddForeignKey(
                name: "FK_BookInfo_languages_LanguageId",
                table: "BookInfo",
                column: "LanguageId",
                principalTable: "languages",
                principalColumn: "LanguageId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
