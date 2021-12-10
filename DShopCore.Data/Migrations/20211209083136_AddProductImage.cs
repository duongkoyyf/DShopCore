using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DShopCore.Data.Migrations
{
    public partial class AddProductImage : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 12, 8, 18, 4, 52, 538, DateTimeKind.Local).AddTicks(9943));

            migrationBuilder.CreateTable(
                name: "ProductImages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    ImagePath = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Captions = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    IsDefault = table.Column<bool>(type: "bit", nullable: false),
                    DateCreate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SortOrder = table.Column<int>(type: "int", nullable: false),
                    FileSize = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductImages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductImages_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_ProductImages_ProductId",
                table: "ProductImages",
                column: "ProductId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProductImages");

            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 12, 8, 18, 4, 52, 538, DateTimeKind.Local).AddTicks(9943),
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("e58f3a6f-6cf3-47d3-8a16-d0b23b40cbd7"),
                column: "ConcurrencyStamp",
                value: "4cb43297-dcca-4bc5-b018-a8b2573b5661");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("d78d9bdf-dace-4182-b43b-3255ca3ab9d7"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "bc1e7c50-8bf5-4506-bc5e-3a5ea5fc0cc5", "AQAAAAEAACcQAAAAEEsPRppS4UuNeycjJIo8ncUy+AKZ8nJdOSzi4s1thd7HquEN1pvW/HGLCov7HCvLig==" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DataCreate",
                value: new DateTime(2021, 12, 8, 18, 4, 52, 554, DateTimeKind.Local).AddTicks(9474));
        }
    }
}
