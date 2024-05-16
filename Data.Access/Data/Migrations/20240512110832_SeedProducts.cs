using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Web.Data.Access.Migrations
{
    /// <inheritdoc />
    public partial class SeedProducts : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Author", "CategoryId", "Description", "ISBN", "Price", "Title" },
                values: new object[,]
                {
                    { 1, "Stephen King", 5, "The Shining is a horror novel by American author Stephen King. Published in 1977, it is King's third published novel and first hardback bestseller: the success of the book firmly established King as a preeminent author in the horror genre.", "978-0-385-12167-5", 9.9900000000000002, "The Shining" },
                    { 2, "J.R.R. Tolkien", 2, "The Lord....", "978-0-395-19395-7", 19.989999999999998, "The lord of the rings" },
                    { 3, "J.R.R. Tolkien", 2, "The Hobbit, or There and Back Again is a children's fantasy novel by English author J. R. R. Tolkien. It was published on 21 September 1937 to wide critical acclaim, being nominated for the Carnegie Medal and awarded a prize from the New York Herald Tribune for best juvenile fiction.", "978-0-395-19395-7", 14.99, "The Hobbit" },
                    { 4, "Stephen King", 5, "The Stand is a post-apocalyptic dark fantasy novel written by American author Stephen King and first published in 1978 by Doubleday. The plot centers on a pandemic of a weaponized strain of influenza that kills almost the entire world population.", "978-0-385-12167-5", 9.9900000000000002, "The Stand" },
                    { 5, "Stephen King", 5, "It is a 1986 horror novel by American author Stephen King. It was his 22nd book and 18th novel written under his own name. The story follows the experiences of seven children as they are terrorized by an evil entity that exploits the fears of its victims to disguise itself while hunting its prey.", "978-0-670-81302-8", 9.9900000000000002, "It" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5);
        }
    }
}
