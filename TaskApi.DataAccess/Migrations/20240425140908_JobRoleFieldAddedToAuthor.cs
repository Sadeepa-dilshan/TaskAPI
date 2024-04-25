using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TaskAPI.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class JobRoleFieldAddedToAuthor : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "JobRole",
                table: "Authors",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 1,
                column: "JobRole",
                value: "Developer");

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 2,
                column: "JobRole",
                value: "QA");

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 3,
                column: "JobRole",
                value: "PM");

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 4,
                column: "JobRole",
                value: "SE");

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Due" },
                values: new object[] { new DateTime(2024, 4, 25, 19, 39, 6, 550, DateTimeKind.Local).AddTicks(9545), new DateTime(2024, 4, 30, 19, 39, 6, 550, DateTimeKind.Local).AddTicks(9563) });

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "Due" },
                values: new object[] { new DateTime(2024, 4, 25, 19, 39, 6, 550, DateTimeKind.Local).AddTicks(9573), new DateTime(2024, 4, 30, 19, 39, 6, 550, DateTimeKind.Local).AddTicks(9574) });

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "Due" },
                values: new object[] { new DateTime(2024, 4, 25, 19, 39, 6, 550, DateTimeKind.Local).AddTicks(9577), new DateTime(2024, 4, 30, 19, 39, 6, 550, DateTimeKind.Local).AddTicks(9578) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "JobRole",
                table: "Authors");

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Due" },
                values: new object[] { new DateTime(2024, 4, 23, 10, 50, 50, 146, DateTimeKind.Local).AddTicks(8883), new DateTime(2024, 4, 28, 10, 50, 50, 146, DateTimeKind.Local).AddTicks(8967) });

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "Due" },
                values: new object[] { new DateTime(2024, 4, 23, 10, 50, 50, 146, DateTimeKind.Local).AddTicks(8996), new DateTime(2024, 4, 28, 10, 50, 50, 146, DateTimeKind.Local).AddTicks(8997) });

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "Due" },
                values: new object[] { new DateTime(2024, 4, 23, 10, 50, 50, 146, DateTimeKind.Local).AddTicks(9043), new DateTime(2024, 4, 28, 10, 50, 50, 146, DateTimeKind.Local).AddTicks(9044) });
        }
    }
}
