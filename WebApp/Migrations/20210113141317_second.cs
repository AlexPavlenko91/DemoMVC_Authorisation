using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApp.Migrations
{
    public partial class second : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "c7dee2f9-cb8e-4112-9531-59128f39992a", "3937d760-e137-41aa-bef9-dec77c4d933d", "Administrators", "ADMINISTRATORS" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "dd0d6b4c-07c4-4ecd-ab52-2fc2444aa6fc", "b56dc10a-aa21-451e-99de-7dfad5f46679", "Moderators", "MODERATORS" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c7dee2f9-cb8e-4112-9531-59128f39992a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "dd0d6b4c-07c4-4ecd-ab52-2fc2444aa6fc");
        }
    }
}
