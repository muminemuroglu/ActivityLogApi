using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ActivityLogApi.Migrations
{
    /// <inheritdoc />
    public partial class AddWorkoutAndGoalTables1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Goals_Users_UserId1",
                table: "Goals");

            migrationBuilder.DropForeignKey(
                name: "FK_Workouts_Users_UserId1",
                table: "Workouts");

            migrationBuilder.DropIndex(
                name: "IX_Workouts_UserId1",
                table: "Workouts");

            migrationBuilder.DropIndex(
                name: "IX_Workouts_WorkoutName",
                table: "Workouts");

            migrationBuilder.DropIndex(
                name: "IX_Goals_UserId1",
                table: "Goals");

            migrationBuilder.RenameColumn(
                name: "Wid",
                table: "Workouts",
                newName: "WId");

            migrationBuilder.RenameColumn(
                name: "UserId1",
                table: "Workouts",
                newName: "CaloriesBurned");

            migrationBuilder.RenameColumn(
                name: "Gid",
                table: "Goals",
                newName: "GId");

            migrationBuilder.RenameColumn(
                name: "UserId1",
                table: "Goals",
                newName: "IsCompleted");

            migrationBuilder.CreateIndex(
                name: "IX_Workouts_UserId",
                table: "Workouts",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Goals_UserId",
                table: "Goals",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Goals_Users_UserId",
                table: "Goals",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Workouts_Users_UserId",
                table: "Workouts",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Goals_Users_UserId",
                table: "Goals");

            migrationBuilder.DropForeignKey(
                name: "FK_Workouts_Users_UserId",
                table: "Workouts");

            migrationBuilder.DropIndex(
                name: "IX_Workouts_UserId",
                table: "Workouts");

            migrationBuilder.DropIndex(
                name: "IX_Goals_UserId",
                table: "Goals");

            migrationBuilder.RenameColumn(
                name: "WId",
                table: "Workouts",
                newName: "Wid");

            migrationBuilder.RenameColumn(
                name: "CaloriesBurned",
                table: "Workouts",
                newName: "UserId1");

            migrationBuilder.RenameColumn(
                name: "GId",
                table: "Goals",
                newName: "Gid");

            migrationBuilder.RenameColumn(
                name: "IsCompleted",
                table: "Goals",
                newName: "UserId1");

            migrationBuilder.CreateIndex(
                name: "IX_Workouts_UserId1",
                table: "Workouts",
                column: "UserId1");

            migrationBuilder.CreateIndex(
                name: "IX_Workouts_WorkoutName",
                table: "Workouts",
                column: "WorkoutName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Goals_UserId1",
                table: "Goals",
                column: "UserId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Goals_Users_UserId1",
                table: "Goals",
                column: "UserId1",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Workouts_Users_UserId1",
                table: "Workouts",
                column: "UserId1",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
