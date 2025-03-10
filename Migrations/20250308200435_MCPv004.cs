using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MCPowerlifting.Migrations
{
    /// <inheritdoc />
    public partial class MCPv004 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "failure_in_row",
                table: "workoutExercises",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "failure_in_row",
                table: "workoutExercises");
        }
    }
}
