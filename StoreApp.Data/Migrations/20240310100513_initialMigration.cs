using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace StoreApp.Data.Migrations
{
    /// <inheritdoc />
    public partial class initialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: false),
                    Price = table.Column<decimal>(type: "TEXT", nullable: false),
                    Category = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Category", "Description", "Name", "Price" },
                values: new object[,]
                {
                    { 1, "Telefon", "Yeni nesil Iphone", "iPhone Pro 14 Pro", 1400m },
                    { 2, "Tablet", "Digital not defteri", "reMarkable 3.0", 500m },
                    { 3, "Tablet", "Digital not defteri", "reMarkable 2.0", 300m },
                    { 4, "Laptop", "Laptop", "MacBook Pro", 3000m },
                    { 5, "Laptop", "Yeni nesil Game Laptop", "Asus Rog Game ", 2700m },
                    { 6, "Monitor", "Oyucnular icin hizli monitor", "NOC Bildschirm 21 Zoll", 485m },
                    { 7, "TV", "OLED TV", "Samsung 65 inc TV", 1252m },
                    { 8, "Elektrikli ev Aletleri", "Yeni nesil elektrikli süpürge", "Dyson 14", 250m }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
