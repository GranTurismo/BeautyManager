using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BeautyManager.Shared.Migrations
{
    /// <inheritdoc />
    public partial class addBeautyTasksDbSet : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BeautyBooks_BeautyTask_TaskId",
                table: "BeautyBooks");

            migrationBuilder.DropTable(
                name: "BeautyTask");

            migrationBuilder.CreateTable(
                name: "BeautyTasks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    TaskTitle = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    TaskDuration = table.Column<TimeOnly>(type: "time(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BeautyTasks", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "BeautyTasks",
                columns: new[] { "Id", "TaskDuration", "TaskTitle" },
                values: new object[,]
                {
                    { 1, new TimeOnly(1, 0, 0), "Man haircut" },
                    { 2, new TimeOnly(1, 30, 0), "Man haircut + beard" },
                    { 3, new TimeOnly(0, 30, 0), "Man beard" },
                    { 4, new TimeOnly(1, 30, 0), "Woman haircut" },
                    { 5, new TimeOnly(2, 0, 0), "Woman haircut + hair wash" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_BeautyBooks_BeautyTasks_TaskId",
                table: "BeautyBooks",
                column: "TaskId",
                principalTable: "BeautyTasks",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BeautyBooks_BeautyTasks_TaskId",
                table: "BeautyBooks");

            migrationBuilder.DropTable(
                name: "BeautyTasks");

            migrationBuilder.CreateTable(
                name: "BeautyTask",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    TaskDuration = table.Column<TimeOnly>(type: "time(6)", nullable: false),
                    TaskTitle = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BeautyTask", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

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

            migrationBuilder.AddForeignKey(
                name: "FK_BeautyBooks_BeautyTask_TaskId",
                table: "BeautyBooks",
                column: "TaskId",
                principalTable: "BeautyTask",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
