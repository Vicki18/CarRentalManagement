using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarRentalManagement.Migrations
{
    /// <inheritdoc />
    public partial class SeedUserRole : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 30, 20, 55, 24, 350, DateTimeKind.Local).AddTicks(7487), new DateTime(2025, 11, 30, 20, 55, 24, 350, DateTimeKind.Local).AddTicks(7502) });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 30, 20, 55, 24, 350, DateTimeKind.Local).AddTicks(7504), new DateTime(2025, 11, 30, 20, 55, 24, 350, DateTimeKind.Local).AddTicks(7505) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 30, 20, 55, 24, 350, DateTimeKind.Local).AddTicks(7656), new DateTime(2025, 11, 30, 20, 55, 24, 350, DateTimeKind.Local).AddTicks(7657) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 30, 20, 55, 24, 350, DateTimeKind.Local).AddTicks(7658), new DateTime(2025, 11, 30, 20, 55, 24, 350, DateTimeKind.Local).AddTicks(7658) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 30, 20, 55, 24, 350, DateTimeKind.Local).AddTicks(7722), new DateTime(2025, 11, 30, 20, 55, 24, 350, DateTimeKind.Local).AddTicks(7723) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 30, 20, 55, 24, 350, DateTimeKind.Local).AddTicks(7724), new DateTime(2025, 11, 30, 20, 55, 24, 350, DateTimeKind.Local).AddTicks(7724) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 30, 20, 55, 24, 350, DateTimeKind.Local).AddTicks(7725), new DateTime(2025, 11, 30, 20, 55, 24, 350, DateTimeKind.Local).AddTicks(7726) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 30, 20, 55, 24, 350, DateTimeKind.Local).AddTicks(7727), new DateTime(2025, 11, 30, 20, 55, 24, 350, DateTimeKind.Local).AddTicks(7727) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 30, 20, 37, 25, 49, DateTimeKind.Local).AddTicks(4058), new DateTime(2025, 11, 30, 20, 37, 25, 49, DateTimeKind.Local).AddTicks(4073) });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 30, 20, 37, 25, 49, DateTimeKind.Local).AddTicks(4075), new DateTime(2025, 11, 30, 20, 37, 25, 49, DateTimeKind.Local).AddTicks(4075) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 30, 20, 37, 25, 49, DateTimeKind.Local).AddTicks(4224), new DateTime(2025, 11, 30, 20, 37, 25, 49, DateTimeKind.Local).AddTicks(4225) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 30, 20, 37, 25, 49, DateTimeKind.Local).AddTicks(4226), new DateTime(2025, 11, 30, 20, 37, 25, 49, DateTimeKind.Local).AddTicks(4227) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 30, 20, 37, 25, 49, DateTimeKind.Local).AddTicks(4302), new DateTime(2025, 11, 30, 20, 37, 25, 49, DateTimeKind.Local).AddTicks(4303) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 30, 20, 37, 25, 49, DateTimeKind.Local).AddTicks(4304), new DateTime(2025, 11, 30, 20, 37, 25, 49, DateTimeKind.Local).AddTicks(4304) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 30, 20, 37, 25, 49, DateTimeKind.Local).AddTicks(4305), new DateTime(2025, 11, 30, 20, 37, 25, 49, DateTimeKind.Local).AddTicks(4306) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 30, 20, 37, 25, 49, DateTimeKind.Local).AddTicks(4307), new DateTime(2025, 11, 30, 20, 37, 25, 49, DateTimeKind.Local).AddTicks(4307) });
        }
    }
}
