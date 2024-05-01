using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StoreApp.Migrations
{
    public partial class seedRole : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "700eabd0-e7a5-4a80-a996-323bf0114798");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8568331c-0058-4fff-8cac-ae2faae5f705");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d86fd23a-66b4-4b2f-8e41-8a247c280cf4");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "0c344869-e92c-4851-bedf-4e7eba6e1e9d", "55230efa-e1eb-405f-8b0c-fbe5e831bf4d", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "6f500dc3-42de-42bb-9414-ed3f82a87e9a", "2644f073-f600-4f14-b934-535cbeb7f9e9", "Editor", "EDITOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "d8a67df8-ee58-40b3-b4cd-3bc5f5fa8596", "3b10e30c-eb3a-46b5-9339-24503dd90230", "Admin", "ADMIN" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0c344869-e92c-4851-bedf-4e7eba6e1e9d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6f500dc3-42de-42bb-9414-ed3f82a87e9a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d8a67df8-ee58-40b3-b4cd-3bc5f5fa8596");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "700eabd0-e7a5-4a80-a996-323bf0114798", "816366c1-b39f-4e5d-9e7f-1a0120943c26", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "8568331c-0058-4fff-8cac-ae2faae5f705", "f2ed6db5-4a26-4215-885c-b9fccfe429b9", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "d86fd23a-66b4-4b2f-8e41-8a247c280cf4", "ee66d9e9-9c0d-4a6b-8969-e0e05a9f5178", "Editor", "EDITOR" });
        }
    }
}
