using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Database.Migrations
{
    /// <inheritdoc />
    public partial class pricehistory2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductPriceHistory_Products_ProductId",
                table: "ProductPriceHistory");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProductPriceHistory",
                table: "ProductPriceHistory");

            migrationBuilder.RenameTable(
                name: "ProductPriceHistory",
                newName: "ProductPriceHistories");

            migrationBuilder.RenameIndex(
                name: "IX_ProductPriceHistory_ProductId",
                table: "ProductPriceHistories",
                newName: "IX_ProductPriceHistories_ProductId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProductPriceHistories",
                table: "ProductPriceHistories",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductPriceHistories_Products_ProductId",
                table: "ProductPriceHistories",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductPriceHistories_Products_ProductId",
                table: "ProductPriceHistories");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProductPriceHistories",
                table: "ProductPriceHistories");

            migrationBuilder.RenameTable(
                name: "ProductPriceHistories",
                newName: "ProductPriceHistory");

            migrationBuilder.RenameIndex(
                name: "IX_ProductPriceHistories_ProductId",
                table: "ProductPriceHistory",
                newName: "IX_ProductPriceHistory_ProductId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProductPriceHistory",
                table: "ProductPriceHistory",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductPriceHistory_Products_ProductId",
                table: "ProductPriceHistory",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
