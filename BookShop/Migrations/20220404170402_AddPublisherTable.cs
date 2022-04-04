using Microsoft.EntityFrameworkCore.Migrations;

namespace BookShop.Migrations
{
    public partial class AddPublisherTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PublisherId",
                table: "BookInfo",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "publishers",
                columns: table => new
                {
                    PublisherId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PublisherName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_publishers", x => x.PublisherId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BookInfo_PublisherId",
                table: "BookInfo",
                column: "PublisherId");

            migrationBuilder.AddForeignKey(
                name: "FK_BookInfo_publishers_PublisherId",
                table: "BookInfo",
                column: "PublisherId",
                principalTable: "publishers",
                principalColumn: "PublisherId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BookInfo_publishers_PublisherId",
                table: "BookInfo");

            migrationBuilder.DropTable(
                name: "publishers");

            migrationBuilder.DropIndex(
                name: "IX_BookInfo_PublisherId",
                table: "BookInfo");

            migrationBuilder.DropColumn(
                name: "PublisherId",
                table: "BookInfo");
        }
    }
}
