using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BookShop.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class SeedingCompanyData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Companies",
                columns: new[] { "Id", "City", "Name", "PhoneNumber", "PostalCode", "State", "StreetAddress" },
                values: new object[,]
                {
                    { 1, "Prishtine", "Botek", "+383 44 166 677", "10000", "KS", "Aktash, rr. Tahir Zajmi, nr. 10" },
                    { 2, "Peje", "Librarija Dukagjini", "+383 44 190 721", "30000", "KS", "Qendra Zejtare, rr. Bedri Pejani, nr. 7" },
                    { 3, "Prishtine", "Buzuku", "+383 45 460 813", "10000", "KS", "Qendra e Qytetit, rr. Nene Tereza, nr. 14" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
