using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Final_Project.Migrations
{
    /// <inheritdoc />
    public partial class v6 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_orders_customers_customerId",
                table: "orders");

            migrationBuilder.DropIndex(
                name: "IX_orders_customerId",
                table: "orders");

            migrationBuilder.DropColumn(
                name: "customerId",
                table: "orders");

            migrationBuilder.CreateIndex(
                name: "IX_orders_customer_id",
                table: "orders",
                column: "customer_id");

            migrationBuilder.AddForeignKey(
                name: "FK_orders_customers_customer_id",
                table: "orders",
                column: "customer_id",
                principalTable: "customers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_orders_customers_customer_id",
                table: "orders");

            migrationBuilder.DropIndex(
                name: "IX_orders_customer_id",
                table: "orders");

            migrationBuilder.AddColumn<int>(
                name: "customerId",
                table: "orders",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_orders_customerId",
                table: "orders",
                column: "customerId");

            migrationBuilder.AddForeignKey(
                name: "FK_orders_customers_customerId",
                table: "orders",
                column: "customerId",
                principalTable: "customers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
