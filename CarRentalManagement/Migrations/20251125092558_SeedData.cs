using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarRentalManagement.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 25, 17, 25, 57, 900, DateTimeKind.Local).AddTicks(6084), new DateTime(2025, 11, 25, 17, 25, 57, 900, DateTimeKind.Local).AddTicks(6118) });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 25, 17, 25, 57, 900, DateTimeKind.Local).AddTicks(6122), new DateTime(2025, 11, 25, 17, 25, 57, 900, DateTimeKind.Local).AddTicks(6123) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 25, 17, 25, 57, 900, DateTimeKind.Local).AddTicks(6666), new DateTime(2025, 11, 25, 17, 25, 57, 900, DateTimeKind.Local).AddTicks(6668) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 25, 17, 25, 57, 900, DateTimeKind.Local).AddTicks(6671), new DateTime(2025, 11, 25, 17, 25, 57, 900, DateTimeKind.Local).AddTicks(6672) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 25, 17, 25, 57, 900, DateTimeKind.Local).AddTicks(6785), new DateTime(2025, 11, 25, 17, 25, 57, 900, DateTimeKind.Local).AddTicks(6786) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 25, 17, 25, 57, 900, DateTimeKind.Local).AddTicks(6788), new DateTime(2025, 11, 25, 17, 25, 57, 900, DateTimeKind.Local).AddTicks(6789) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 25, 17, 25, 57, 900, DateTimeKind.Local).AddTicks(6791), new DateTime(2025, 11, 25, 17, 25, 57, 900, DateTimeKind.Local).AddTicks(6792) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated", "Name" },
                values: new object[] { new DateTime(2025, 11, 25, 17, 25, 57, 900, DateTimeKind.Local).AddTicks(6795), new DateTime(2025, 11, 25, 17, 25, 57, 900, DateTimeKind.Local).AddTicks(6796), "C-HR" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 25, 17, 16, 41, 431, DateTimeKind.Local).AddTicks(1884), new DateTime(2025, 11, 25, 17, 16, 41, 431, DateTimeKind.Local).AddTicks(1913) });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 25, 17, 16, 41, 431, DateTimeKind.Local).AddTicks(1914), new DateTime(2025, 11, 25, 17, 16, 41, 431, DateTimeKind.Local).AddTicks(1915) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 25, 17, 16, 41, 431, DateTimeKind.Local).AddTicks(2162), new DateTime(2025, 11, 25, 17, 16, 41, 431, DateTimeKind.Local).AddTicks(2162) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 25, 17, 16, 41, 431, DateTimeKind.Local).AddTicks(2163), new DateTime(2025, 11, 25, 17, 16, 41, 431, DateTimeKind.Local).AddTicks(2164) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 25, 17, 16, 41, 431, DateTimeKind.Local).AddTicks(2228), new DateTime(2025, 11, 25, 17, 16, 41, 431, DateTimeKind.Local).AddTicks(2228) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 25, 17, 16, 41, 431, DateTimeKind.Local).AddTicks(2230), new DateTime(2025, 11, 25, 17, 16, 41, 431, DateTimeKind.Local).AddTicks(2230) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 25, 17, 16, 41, 431, DateTimeKind.Local).AddTicks(2231), new DateTime(2025, 11, 25, 17, 16, 41, 431, DateTimeKind.Local).AddTicks(2232) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated", "Name" },
                values: new object[] { new DateTime(2025, 11, 25, 17, 16, 41, 431, DateTimeKind.Local).AddTicks(2233), new DateTime(2025, 11, 25, 17, 16, 41, 431, DateTimeKind.Local).AddTicks(2233), "" });
        }
    }
}
