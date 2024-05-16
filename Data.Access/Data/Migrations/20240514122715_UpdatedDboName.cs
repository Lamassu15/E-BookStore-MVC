using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Web.Data.Access.Migrations
{
    /// <inheritdoc />
    public partial class UpdatedDboName : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Shoppingcarts_AspNetUsers_ApplicationUserId",
                table: "Shoppingcarts");

            migrationBuilder.DropForeignKey(
                name: "FK_Shoppingcarts_Products_ProductId",
                table: "Shoppingcarts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Shoppingcarts",
                table: "Shoppingcarts");

            migrationBuilder.RenameTable(
                name: "Shoppingcarts",
                newName: "ShoppingCarts");

            migrationBuilder.RenameIndex(
                name: "IX_Shoppingcarts_ProductId",
                table: "ShoppingCarts",
                newName: "IX_ShoppingCarts_ProductId");

            migrationBuilder.RenameIndex(
                name: "IX_Shoppingcarts_ApplicationUserId",
                table: "ShoppingCarts",
                newName: "IX_ShoppingCarts_ApplicationUserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ShoppingCarts",
                table: "ShoppingCarts",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ShoppingCarts_AspNetUsers_ApplicationUserId",
                table: "ShoppingCarts",
                column: "ApplicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ShoppingCarts_Products_ProductId",
                table: "ShoppingCarts",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ShoppingCarts_AspNetUsers_ApplicationUserId",
                table: "ShoppingCarts");

            migrationBuilder.DropForeignKey(
                name: "FK_ShoppingCarts_Products_ProductId",
                table: "ShoppingCarts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ShoppingCarts",
                table: "ShoppingCarts");

            migrationBuilder.RenameTable(
                name: "ShoppingCarts",
                newName: "Shoppingcarts");

            migrationBuilder.RenameIndex(
                name: "IX_ShoppingCarts_ProductId",
                table: "Shoppingcarts",
                newName: "IX_Shoppingcarts_ProductId");

            migrationBuilder.RenameIndex(
                name: "IX_ShoppingCarts_ApplicationUserId",
                table: "Shoppingcarts",
                newName: "IX_Shoppingcarts_ApplicationUserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Shoppingcarts",
                table: "Shoppingcarts",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Shoppingcarts_AspNetUsers_ApplicationUserId",
                table: "Shoppingcarts",
                column: "ApplicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Shoppingcarts_Products_ProductId",
                table: "Shoppingcarts",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
