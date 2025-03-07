using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MCPowerlifting.Migrations
{
    /// <inheritdoc />
    public partial class MCPv002 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "actual_reps",
                table: "workoutExercises");

            migrationBuilder.DropColumn(
                name: "actual_sets",
                table: "workoutExercises");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "actual_reps",
                table: "workoutExercises",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "actual_sets",
                table: "workoutExercises",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
