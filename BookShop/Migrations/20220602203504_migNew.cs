using Microsoft.EntityFrameworkCore.Migrations;

namespace BookShop.Migrations
{
    public partial class migNew : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Count",
                table: "BookInfo");

            migrationBuilder.DropColumn(
                name: "NumOfPage",
                table: "BookInfo");

            migrationBuilder.DropColumn(
                name: "Weight",
                table: "BookInfo");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Count",
                table: "BookInfo",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "NumOfPage",
                table: "BookInfo",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<short>(
                name: "Weight",
                table: "BookInfo",
                type: "smallint",
                nullable: false,
                defaultValue: (short)0);
        }
    }
}
