using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjectKard.Migrations
{
    /// <inheritdoc />
    public partial class SeedData1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "Type", "UpdatedBy" },
                values: new object[] { 1, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pokemon", "Turn Based Fighting Game", null });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
