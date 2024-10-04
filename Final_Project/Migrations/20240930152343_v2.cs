using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Final_Project.Migrations
{
    /// <inheritdoc />
    public partial class v2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_products_category",
                table: "products_category");

            migrationBuilder.DropPrimaryKey(
                name: "PK_order_details",
                table: "order_details");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "products_category");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "order_details");

            migrationBuilder.AddColumn<int>(
                name: "customerId",
                table: "orders",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_products_category",
                table: "products_category",
                columns: new[] { "category_id", "product_id" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_order_details",
                table: "order_details",
                columns: new[] { "product_id", "order_id" });

            migrationBuilder.CreateIndex(
                name: "IX_products_category_product_id",
                table: "products_category",
                column: "product_id");

            migrationBuilder.CreateIndex(
                name: "IX_orders_customerId",
                table: "orders",
                column: "customerId");

            migrationBuilder.CreateIndex(
                name: "IX_order_details_order_id",
                table: "order_details",
                column: "order_id");

            migrationBuilder.AddForeignKey(
                name: "FK_order_details_orders_order_id",
                table: "order_details",
                column: "order_id",
                principalTable: "orders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_order_details_products_product_id",
                table: "order_details",
                column: "product_id",
                principalTable: "products",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_orders_customers_customerId",
                table: "orders",
                column: "customerId",
                principalTable: "customers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_products_category_categories_category_id",
                table: "products_category",
                column: "category_id",
                principalTable: "categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_products_category_products_product_id",
                table: "products_category",
                column: "product_id",
                principalTable: "products",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_order_details_orders_order_id",
                table: "order_details");

            migrationBuilder.DropForeignKey(
                name: "FK_order_details_products_product_id",
                table: "order_details");

            migrationBuilder.DropForeignKey(
                name: "FK_orders_customers_customerId",
                table: "orders");

            migrationBuilder.DropForeignKey(
                name: "FK_products_category_categories_category_id",
                table: "products_category");

            migrationBuilder.DropForeignKey(
                name: "FK_products_category_products_product_id",
                table: "products_category");

            migrationBuilder.DropPrimaryKey(
                name: "PK_products_category",
                table: "products_category");

            migrationBuilder.DropIndex(
                name: "IX_products_category_product_id",
                table: "products_category");

            migrationBuilder.DropIndex(
                name: "IX_orders_customerId",
                table: "orders");

            migrationBuilder.DropPrimaryKey(
                name: "PK_order_details",
                table: "order_details");

            migrationBuilder.DropIndex(
                name: "IX_order_details_order_id",
                table: "order_details");

            migrationBuilder.DropColumn(
                name: "customerId",
                table: "orders");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "products_category",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "order_details",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_products_category",
                table: "products_category",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_order_details",
                table: "order_details",
                column: "Id");
        }
    }
}
