using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DShopCore.Data.Migrations
{
    public partial class seed_IdentityUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 12, 8, 18, 4, 52, 538, DateTimeKind.Local).AddTicks(9943),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 12, 8, 17, 49, 30, 950, DateTimeKind.Local).AddTicks(2400));

            migrationBuilder.InsertData(
                table: "AppRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Description", "Name", "NormalizedName" },
                values: new object[] { new Guid("e58f3a6f-6cf3-47d3-8a16-d0b23b40cbd7"), "4cb43297-dcca-4bc5-b018-a8b2573b5661", "Administrator role", "admin", "admin" });

            migrationBuilder.InsertData(
                table: "AppUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { new Guid("e58f3a6f-6cf3-47d3-8a16-d0b23b40cbd7"), new Guid("d78d9bdf-dace-4182-b43b-3255ca3ab9d7") });

            migrationBuilder.InsertData(
                table: "AppUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Dob", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("d78d9bdf-dace-4182-b43b-3255ca3ab9d7"), 0, "bc1e7c50-8bf5-4506-bc5e-3a5ea5fc0cc5", new DateTime(2020, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "tedu.international@gmail.com", true, "Toan", "Bach", false, null, "tedu.international@gmail.com", "admin", "AQAAAAEAACcQAAAAEEsPRppS4UuNeycjJIo8ncUy+AKZ8nJdOSzi4s1thd7HquEN1pvW/HGLCov7HCvLig==", null, false, "", false, "admin" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DataCreate",
                value: new DateTime(2021, 12, 8, 18, 4, 52, 554, DateTimeKind.Local).AddTicks(9474));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("e58f3a6f-6cf3-47d3-8a16-d0b23b40cbd7"));

            migrationBuilder.DeleteData(
                table: "AppUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("e58f3a6f-6cf3-47d3-8a16-d0b23b40cbd7"), new Guid("d78d9bdf-dace-4182-b43b-3255ca3ab9d7") });

            migrationBuilder.DeleteData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("d78d9bdf-dace-4182-b43b-3255ca3ab9d7"));

            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 12, 8, 17, 49, 30, 950, DateTimeKind.Local).AddTicks(2400),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 12, 8, 18, 4, 52, 538, DateTimeKind.Local).AddTicks(9943));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DataCreate",
                value: new DateTime(2021, 12, 8, 17, 49, 30, 970, DateTimeKind.Local).AddTicks(158));
        }
    }
}
