using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TaskAPI.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class AuthorEntityAndData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AuthorId",
                table: "Todos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Authors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Authors", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "FullName" },
                values: new object[,]
                {
                    { 1, "Mgs dilshan" },
                    { 2, "Sunil Bandara" },
                    { 3, "Chaminda Bandara" },
                    { 4, "Hansi Gamage" }
                });

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AuthorId", "Created", "Description", "Due", "Status", "Title" },
                values: new object[] { 1, new DateTime(2024, 4, 19, 22, 34, 53, 618, DateTimeKind.Local).AddTicks(9039), "Get some text books for school", new DateTime(2024, 4, 24, 22, 34, 53, 618, DateTimeKind.Local).AddTicks(9052), 0, "Get books for school - DB" });

            migrationBuilder.InsertData(
                table: "Todos",
                columns: new[] { "Id", "AuthorId", "Created", "Description", "Due", "Status", "Title" },
                values: new object[,]
                {
                    { 2, 1, new DateTime(2024, 4, 19, 22, 34, 53, 618, DateTimeKind.Local).AddTicks(9159), "Go to supermarket and buy some stuff", new DateTime(2024, 4, 24, 22, 34, 53, 618, DateTimeKind.Local).AddTicks(9160), 0, "Need some grocceries" },
                    { 3, 2, new DateTime(2024, 4, 19, 22, 34, 53, 618, DateTimeKind.Local).AddTicks(9164), "Buy new camera", new DateTime(2024, 4, 24, 22, 34, 53, 618, DateTimeKind.Local).AddTicks(9165), 0, "Purchase camera" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Todos_AuthorId",
                table: "Todos",
                column: "AuthorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Todos_Authors_AuthorId",
                table: "Todos",
                column: "AuthorId",
                principalTable: "Authors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Todos_Authors_AuthorId",
                table: "Todos");

            migrationBuilder.DropTable(
                name: "Authors");

            migrationBuilder.DropIndex(
                name: "IX_Todos_AuthorId",
                table: "Todos");

            migrationBuilder.DeleteData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DropColumn(
                name: "AuthorId",
                table: "Todos");

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Description", "Due", "Status", "Title" },
                values: new object[] { new DateTime(2024, 4, 19, 15, 35, 46, 594, DateTimeKind.Local).AddTicks(8560), "Test - db", new DateTime(2024, 4, 24, 15, 35, 46, 594, DateTimeKind.Local).AddTicks(8574), 2, "Test" });
        }
    }
}
