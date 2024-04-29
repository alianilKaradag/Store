using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StoreApp.Migrations
{
    public partial class IdentityRoleSeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "12ceb868-d049-4d89-8d24-759ed62810ba");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a6496913-9dff-4359-9e74-7b6c95ee0260");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bcc4f93c-d853-4c76-b4a5-64ff1629f37c");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "3af3834e-631a-4375-9569-168446e2d962", "1fed0c3d-23fd-44bb-948b-f77bccd339f5", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "4e7f494e-3fe4-4225-bc8e-6c35c75eff6f", "30009ce6-81d8-4406-a876-a55e7b7ae18b", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "966a4b5d-1d14-40b9-bc82-485714b28762", "1a961d7c-d3d6-4447-be4f-9092600f370a", "Editor", "EDITOR" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3af3834e-631a-4375-9569-168446e2d962");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4e7f494e-3fe4-4225-bc8e-6c35c75eff6f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "966a4b5d-1d14-40b9-bc82-485714b28762");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "12ceb868-d049-4d89-8d24-759ed62810ba", "b0204574-87ce-4b28-9375-57d3a35c7ee2", "Editor", "EDITOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "a6496913-9dff-4359-9e74-7b6c95ee0260", "b30e8e0f-3ab8-488e-8f8f-a39fc6ed5a25", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "bcc4f93c-d853-4c76-b4a5-64ff1629f37c", "6fb7e93a-5c16-4c15-b467-2b3fff5de569", "Admin", "ADMIN" });
        }
    }
}
