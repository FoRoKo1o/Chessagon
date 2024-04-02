using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Chessagon.Migrations
{
    /// <inheritdoc />
    public partial class SeededUsersAndGames : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Games",
                columns: new[] { "Id", "Player1Id", "Player2Id", "UserId", "WinnerId", "ratingChange" },
                values: new object[,]
                {
                    { 1, 1, 2, null, 2, 10 },
                    { 2, 1, 2, null, 1, 10 },
                    { 3, 1, 2, null, null, 0 }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Description", "Email", "Password", "Rating", "Role", "Username" },
                values: new object[,]
                {
                    { 1, "I'm admin", "admin@admin.com", "admin", 9999, "admin", "admin" },
                    { 2, "I'm user", "user@user.com", "user", 0, "user", "user" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
