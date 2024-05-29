using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Web.Data.Access.Migrations
{
    /// <inheritdoc />
    public partial class NewBookInfo : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "Description",
                value: "The Lord of the Rings is an epic fantasy novel written by J.R.R. Tolkien. Set in the fictional world of Middle-earth, it follows the journey of a young hobbit named Frodo Baggins who is entrusted with the task of destroying the powerful and evil One Ring. Accompanied by his friends and allies, Frodo forms a diverse fellowship consisting of men, elves, dwarves, and other hobbits. Together, they must overcome numerous dangers and obstacles along the way. The story is rich with themes of friendship, courage, the corrupting nature of power, and the battle between good and evil.");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "Description",
                value: "The Lord....");
        }
    }
}
