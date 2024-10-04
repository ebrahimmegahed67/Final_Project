using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Final_Project.Migrations
{
    /// <inheritdoc />
    public partial class v5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "catgory_id",
                table: "products");

            migrationBuilder.AddColumn<string>(
                name: "catgory",
                table: "products",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "catgory",
                table: "products");

            migrationBuilder.AddColumn<int>(
                name: "catgory_id",
                table: "products",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
