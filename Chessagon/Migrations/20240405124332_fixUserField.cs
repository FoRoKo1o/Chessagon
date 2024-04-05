using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Chessagon.Migrations
{
    /// <inheritdoc />
    public partial class fixUserField : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2b79cc27-82f3-4cb4-9d95-0bccf942ae1a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "403b2c0e-c14d-4472-b2cc-9e89dcf5880c");

            migrationBuilder.RenameColumn(
                name: "isSoftDeleted",
                table: "AspNetUsers",
                newName: "IsSoftDeleted");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "255fb9cf-4b1c-4fee-b236-440a6099730c", null, "Administrator", "ADMIN" },
                    { "6fe0aa4c-a94c-4a92-ad31-56ca823a78f4", null, "User", "USER" }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "b21c3d75-5da4-4433-9a76-adb509915927", "fb3075b4-e496-402f-9dc3-33afb6aa86df" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "1a5df82d-d7be-40ae-bb64-3ef533d23189", "22cba366-f4a1-44aa-bd36-019771739aeb" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "39be1149-7291-4eb4-b3f2-3c37ecec5576", "2c323814-a1a6-4d7b-b5b9-45696f2d459b" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "255fb9cf-4b1c-4fee-b236-440a6099730c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6fe0aa4c-a94c-4a92-ad31-56ca823a78f4");

            migrationBuilder.RenameColumn(
                name: "IsSoftDeleted",
                table: "AspNetUsers",
                newName: "isSoftDeleted");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "2b79cc27-82f3-4cb4-9d95-0bccf942ae1a", null, "User", "USER" },
                    { "403b2c0e-c14d-4472-b2cc-9e89dcf5880c", null, "Administrator", "ADMIN" }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "da3d0c74-0f61-4f6c-b844-9923d512e783", "e3461b0c-3a7f-4382-a251-3a032e0b9fba" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "6364af5e-d728-4937-a186-cb97e27e7a52", "9735ad13-b552-4965-b2c5-2653759a1391" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "a409fdb9-ae63-46b3-aa3b-d26a5a430de1", "69b5a221-a97c-4d1d-b215-439fdbbf4ee3" });
        }
    }
}
