using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Internet.Migrations
{
    /// <inheritdoc />
    public partial class SupplierId : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Code",
                table: "Furnitures",
                newName: "ProductCode");

            migrationBuilder.AddColumn<int>(
                name: "SupplierId",
                table: "Suppliers",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SupplierId",
                table: "Suppliers");

            migrationBuilder.RenameColumn(
                name: "ProductCode",
                table: "Furnitures",
                newName: "Code");
        }
    }
}
