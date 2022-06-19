using Microsoft.EntityFrameworkCore.Migrations;

namespace BookShop.Migrations.BookShop
{
    public partial class RelationalAspnetUserToCustomer_ : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {

            migrationBuilder.AddForeignKey(
                name: "FK_Customers_AspnetUsers_CustomerId",
                table: "Customers",
                column: "CustomerId",
                principalTable: "AspnetUsers",
                principalColumn: "Id",
                onDelete:ReferentialAction.Restrict
                ); 
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                  name: "FK_Customers_AspnetUsers_CustomerId",
                  table:"Customers"
                );
        }
    }
}
