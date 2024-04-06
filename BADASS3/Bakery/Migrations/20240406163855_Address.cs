using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Bakery.Migrations
{
    /// <inheritdoc />
    public partial class Address : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Delivery_OrderId",
                table: "DispatchSheet",
                column: "CompanyOrderID",
                unique: true);

            // Changed onDelete action from Cascade to Restrict
            migrationBuilder.AddForeignKey(
                name: "FK_Delivery_Order_OrderId",
                table: "DispatchSheet",
                column: "CompanyOrderID",
                principalTable: "CompanyOrder",
                principalColumn: "CompanyOrderID",
                // This is the key change to avoid cascade delete issues
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Delivery_Order_OrderId",
                table: "DispatchSheet");

            migrationBuilder.DropIndex(
                name: "IX_Delivery_OrderId",
                table: "DispatchSheet");
        }
    }
}