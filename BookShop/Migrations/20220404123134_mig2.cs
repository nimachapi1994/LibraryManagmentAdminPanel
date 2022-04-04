using Microsoft.EntityFrameworkCore.Migrations;

namespace BookShop.Migrations
{
    public partial class mig2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Customers_Cities_CityId",
                table: "Customers");

            migrationBuilder.RenameColumn(
                name: "CityId",
                table: "Customers",
                newName: "City2CityId");

            migrationBuilder.RenameIndex(
                name: "IX_Customers_CityId",
                table: "Customers",
                newName: "IX_Customers_City2CityId");

            migrationBuilder.AddColumn<int>(
                name: "City1CityId",
                table: "Customers",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Customers_City1CityId",
                table: "Customers",
                column: "City1CityId");

            migrationBuilder.AddForeignKey(
                name: "FK_Customers_Cities_City1CityId",
                table: "Customers",
                column: "City1CityId",
                principalTable: "Cities",
                principalColumn: "CityId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Customers_Cities_City2CityId",
                table: "Customers",
                column: "City2CityId",
                principalTable: "Cities",
                principalColumn: "CityId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Customers_Cities_City1CityId",
                table: "Customers");

            migrationBuilder.DropForeignKey(
                name: "FK_Customers_Cities_City2CityId",
                table: "Customers");

            migrationBuilder.DropIndex(
                name: "IX_Customers_City1CityId",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "City1CityId",
                table: "Customers");

            migrationBuilder.RenameColumn(
                name: "City2CityId",
                table: "Customers",
                newName: "CityId");

            migrationBuilder.RenameIndex(
                name: "IX_Customers_City2CityId",
                table: "Customers",
                newName: "IX_Customers_CityId");

            migrationBuilder.AddForeignKey(
                name: "FK_Customers_Cities_CityId",
                table: "Customers",
                column: "CityId",
                principalTable: "Cities",
                principalColumn: "CityId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
