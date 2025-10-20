using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BeautyManager.Shared.Migrations
{
    /// <inheritdoc />
    public partial class stylists : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "StylistId",
                table: "BeautyBooks",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Stylists",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stylists", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "BeautyTaskStylists",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    StylistId = table.Column<int>(type: "int", nullable: false),
                    BeautyTaskId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BeautyTaskStylists", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BeautyTaskStylists_BeautyTasks_BeautyTaskId",
                        column: x => x.BeautyTaskId,
                        principalTable: "BeautyTasks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BeautyTaskStylists_Stylists_StylistId",
                        column: x => x.StylistId,
                        principalTable: "Stylists",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "Stylists",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "John Doe" },
                    { 2, "Jane Smith" }
                });

            migrationBuilder.InsertData(
                table: "BeautyTaskStylists",
                columns: new[] { "Id", "BeautyTaskId", "StylistId" },
                values: new object[,]
                {
                    { 1, 1, 1 },
                    { 2, 2, 1 },
                    { 3, 3, 1 },
                    { 4, 4, 2 },
                    { 5, 5, 2 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_BeautyBooks_StylistId",
                table: "BeautyBooks",
                column: "StylistId");

            migrationBuilder.CreateIndex(
                name: "IX_BeautyTaskStylists_BeautyTaskId",
                table: "BeautyTaskStylists",
                column: "BeautyTaskId");

            migrationBuilder.CreateIndex(
                name: "IX_BeautyTaskStylists_StylistId",
                table: "BeautyTaskStylists",
                column: "StylistId");

            migrationBuilder.AddForeignKey(
                name: "FK_BeautyBooks_Stylists_StylistId",
                table: "BeautyBooks",
                column: "StylistId",
                principalTable: "Stylists",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BeautyBooks_Stylists_StylistId",
                table: "BeautyBooks");

            migrationBuilder.DropTable(
                name: "BeautyTaskStylists");

            migrationBuilder.DropTable(
                name: "Stylists");

            migrationBuilder.DropIndex(
                name: "IX_BeautyBooks_StylistId",
                table: "BeautyBooks");

            migrationBuilder.DropColumn(
                name: "StylistId",
                table: "BeautyBooks");
        }
    }
}
