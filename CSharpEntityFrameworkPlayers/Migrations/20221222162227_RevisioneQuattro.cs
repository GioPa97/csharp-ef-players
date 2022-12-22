using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CSharpEntityFrameworkPlayers.Migrations
{
    /// <inheritdoc />
    public partial class RevisioneQuattro : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_player_team_TeamID",
                table: "player");

            migrationBuilder.DropIndex(
                name: "IX_team_Name",
                table: "team");

            migrationBuilder.RenameColumn(
                name: "TeamID",
                table: "player",
                newName: "TeamId");

            migrationBuilder.RenameIndex(
                name: "IX_player_TeamID",
                table: "player",
                newName: "IX_player_TeamId");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "team",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddForeignKey(
                name: "FK_player_team_TeamId",
                table: "player",
                column: "TeamId",
                principalTable: "team",
                principalColumn: "TeamId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_player_team_TeamId",
                table: "player");

            migrationBuilder.RenameColumn(
                name: "TeamId",
                table: "player",
                newName: "TeamID");

            migrationBuilder.RenameIndex(
                name: "IX_player_TeamId",
                table: "player",
                newName: "IX_player_TeamID");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "team",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.CreateIndex(
                name: "IX_team_Name",
                table: "team",
                column: "Name",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_player_team_TeamID",
                table: "player",
                column: "TeamID",
                principalTable: "team",
                principalColumn: "TeamId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
