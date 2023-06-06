using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProductManagement.Data.Migrations
{
    /// <inheritdoc />
    public partial class UpdateSchema : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductCategory_Categories_CategoryId",
                table: "ProductCategory");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductCategory_Products_ProductId",
                table: "ProductCategory");

            migrationBuilder.RenameColumn(
                name: "CategoryId",
                table: "ProductCategory",
                newName: "categoryId");

            migrationBuilder.RenameColumn(
                name: "ProductId",
                table: "ProductCategory",
                newName: "productId");

            migrationBuilder.RenameIndex(
                name: "IX_ProductCategory_CategoryId",
                table: "ProductCategory",
                newName: "IX_ProductCategory_categoryId");

            migrationBuilder.AddColumn<int>(
                name: "categoryId",
                table: "Products",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductCategory_Categories_categoryId",
                table: "ProductCategory",
                column: "categoryId",
                principalTable: "Categories",
                principalColumn: "categoryId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductCategory_Products_productId",
                table: "ProductCategory",
                column: "productId",
                principalTable: "Products",
                principalColumn: "productId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductCategory_Categories_categoryId",
                table: "ProductCategory");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductCategory_Products_productId",
                table: "ProductCategory");

            migrationBuilder.DropColumn(
                name: "categoryId",
                table: "Products");

            migrationBuilder.RenameColumn(
                name: "categoryId",
                table: "ProductCategory",
                newName: "CategoryId");

            migrationBuilder.RenameColumn(
                name: "productId",
                table: "ProductCategory",
                newName: "ProductId");

            migrationBuilder.RenameIndex(
                name: "IX_ProductCategory_categoryId",
                table: "ProductCategory",
                newName: "IX_ProductCategory_CategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductCategory_Categories_CategoryId",
                table: "ProductCategory",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "categoryId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductCategory_Products_ProductId",
                table: "ProductCategory",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "productId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
