using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BeautyManager.Shared.Migrations
{
    /// <inheritdoc />
    public partial class seedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "BeautyTask",
                columns: new[] { "Id", "TaskDuration", "TaskTitle" },
                values: new object[,]
                {
                    { 1, new TimeOnly(1, 0, 0), "Man haircut" },
                    { 2, new TimeOnly(1, 30, 0), "Man haircut + beard" },
                    { 3, new TimeOnly(0, 30, 0), "Man beard" },
                    { 4, new TimeOnly(1, 30, 0), "Woman haircut" },
                    { 5, new TimeOnly(2, 0, 0), "Woman haircut + hair wash" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "BeautyTask",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "BeautyTask",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "BeautyTask",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "BeautyTask",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "BeautyTask",
                keyColumn: "Id",
                keyValue: 5);
        }
    }
}
