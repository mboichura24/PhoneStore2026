using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UI.Migrations
{
    /// <inheritdoc />
    public partial class AddItemTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "Name", "Price" },
                values: new object[] { 1, "вікна", 755.20000000000005 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
