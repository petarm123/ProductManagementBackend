using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProductManagement.Data.Migrations
{
    /// <inheritdoc />
    public partial class categoryId : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductCategory_Categories_CategoriesCategoryId",
                table: "ProductCategory");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductCategory_Products_ProductsProductId",
                table: "ProductCategory");

            migrationBuilder.RenameColumn(
                name: "Price",
                table: "Products",
                newName: "price");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Products",
                newName: "name");

            migrationBuilder.RenameColumn(
                name: "Description",
                table: "Products",
                newName: "description");

            migrationBuilder.RenameColumn(
                name: "ProductId",
                table: "Products",
                newName: "productId");

            migrationBuilder.RenameColumn(
                name: "ProductsProductId",
                table: "ProductCategory",
                newName: "CategoryId");

            migrationBuilder.RenameColumn(
                name: "CategoriesCategoryId",
                table: "ProductCategory",
                newName: "ProductId");

            migrationBuilder.RenameIndex(
                name: "IX_ProductCategory_ProductsProductId",
                table: "ProductCategory",
                newName: "IX_ProductCategory_CategoryId");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Categories",
                newName: "name");

            migrationBuilder.RenameColumn(
                name: "CategoryId",
                table: "Categories",
                newName: "categoryId");

            migrationBuilder.AlterColumn<int>(
                name: "CategoryId",
                table: "ProductCategory",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("Relational:ColumnOrder", 1);

            migrationBuilder.AlterColumn<int>(
                name: "ProductId",
                table: "ProductCategory",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("Relational:ColumnOrder", 0);

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductCategory_Categories_CategoryId",
                table: "ProductCategory");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductCategory_Products_ProductId",
                table: "ProductCategory");

            migrationBuilder.RenameColumn(
                name: "price",
                table: "Products",
                newName: "Price");

            migrationBuilder.RenameColumn(
                name: "name",
                table: "Products",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "description",
                table: "Products",
                newName: "Description");

            migrationBuilder.RenameColumn(
                name: "productId",
                table: "Products",
                newName: "ProductId");

            migrationBuilder.RenameColumn(
                name: "CategoryId",
                table: "ProductCategory",
                newName: "ProductsProductId");

            migrationBuilder.RenameColumn(
                name: "ProductId",
                table: "ProductCategory",
                newName: "CategoriesCategoryId");

            migrationBuilder.RenameIndex(
                name: "IX_ProductCategory_CategoryId",
                table: "ProductCategory",
                newName: "IX_ProductCategory_ProductsProductId");

            migrationBuilder.RenameColumn(
                name: "name",
                table: "Categories",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "categoryId",
                table: "Categories",
                newName: "CategoryId");

            migrationBuilder.AlterColumn<int>(
                name: "ProductsProductId",
                table: "ProductCategory",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("Relational:ColumnOrder", 1);

            migrationBuilder.AlterColumn<int>(
                name: "CategoriesCategoryId",
                table: "ProductCategory",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("Relational:ColumnOrder", 0);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductCategory_Categories_CategoriesCategoryId",
                table: "ProductCategory",
                column: "CategoriesCategoryId",
                principalTable: "Categories",
                principalColumn: "CategoryId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductCategory_Products_ProductsProductId",
                table: "ProductCategory",
                column: "ProductsProductId",
                principalTable: "Products",
                principalColumn: "ProductId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
