using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CovadisLeenAuto.Domain.Migrations
{
    /// <inheritdoc />
    public partial class seedLeenAuto : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "LeenAutos",
                columns: new[] { "ID", "Gereserveerd", "Kenteken", "KilometerStand", "Type" },
                values: new object[] { 2, true, "mw-99-99", 1010, "Fiat Multipla" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "LeenAutos",
                keyColumn: "ID",
                keyValue: 2);
        }
    }
}
