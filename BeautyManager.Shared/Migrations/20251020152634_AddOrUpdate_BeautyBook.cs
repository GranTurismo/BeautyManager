using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BeautyManager.Shared.Migrations
{
    /// <inheritdoc />
    public partial class AddOrUpdate_BeautyBook : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CancellationCode",
                table: "BeautyBooks",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CancellationCode",
                table: "BeautyBooks");
        }
    }
}
