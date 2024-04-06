using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Bakery.Migrations
{
    /// <inheritdoc />
    public partial class Delivery : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            // Since the DeliveryPlace column already exists, the AddColumn operation has been removed
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            // Since the Up migration does not add the DeliveryPlace column,
            // the Down method should not try to remove it. 
            // You should only remove columns in the Down method that were added in the Up method.
        }
    }
}