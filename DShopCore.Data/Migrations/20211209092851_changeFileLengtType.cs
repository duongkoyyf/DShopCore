using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DShopCore.Data.Migrations
{
    public partial class changeFileLengtType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<long>(
                name: "FileSize",
                table: "ProductImages",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("e58f3a6f-6cf3-47d3-8a16-d0b23b40cbd7"),
                column: "ConcurrencyStamp",
                value: "ba3f9b3e-c816-4b58-8370-a30dfdd9362a");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("d78d9bdf-dace-4182-b43b-3255ca3ab9d7"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "99d1d68b-a365-4b7e-b656-e877ef84bb45", "AQAAAAEAACcQAAAAEFOc3LzfJSgaZHeeblcqI/hmtMvDyOpUg07Q4Vjk7vVFHR8jMZEZvn4qtlLksf0DQQ==" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DataCreate",
                value: new DateTime(2021, 12, 9, 16, 28, 50, 267, DateTimeKind.Local).AddTicks(6504));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "FileSize",
                table: "ProductImages",
                type: "int",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("e58f3a6f-6cf3-47d3-8a16-d0b23b40cbd7"),
                column: "ConcurrencyStamp",
                value: "06a60ab9-f319-4b6c-ab88-f61392b171dc");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("d78d9bdf-dace-4182-b43b-3255ca3ab9d7"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "1dd75914-1e81-4ee3-abb0-ab210ac8dde3", "AQAAAAEAACcQAAAAEK5IUfAoXuJKe/r5Z0whe+RXGi6fp77PFaG5B3ML/9idjDj0lpNLyWxkWNBrDhDHyg==" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DataCreate",
                value: new DateTime(2021, 12, 9, 15, 31, 35, 295, DateTimeKind.Local).AddTicks(3671));
        }
    }
}
