using Microsoft.EntityFrameworkCore.Migrations;

namespace BookShop.Migrations
{
    public partial class Add_WeightAdd_NumOfPageAdd_IBSN : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ISBN",
                table: "BookInfo",
                type: "nvarchar(max)",
                nullable: true);

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ISBN",
                table: "BookInfo");

            migrationBuilder.DropColumn(
                name: "NumOfPage",
                table: "BookInfo");

            migrationBuilder.DropColumn(
                name: "Weight",
                table: "BookInfo");
        }
    }
}
