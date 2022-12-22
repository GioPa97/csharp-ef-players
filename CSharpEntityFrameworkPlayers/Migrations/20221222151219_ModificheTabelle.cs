using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CSharpEntityFrameworkPlayers.Migrations
{
    /// <inheritdoc />
    public partial class ModificheTabelle : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "TeamName",
                table: "team",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TeamName",
                table: "player",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_team_TeamName",
                table: "team",
                column: "TeamName");

            migrationBuilder.CreateIndex(
                name: "IX_player_TeamName",
                table: "player",
                column: "TeamName");

            migrationBuilder.AddForeignKey(
                name: "FK_player_team_TeamName",
                table: "player",
                column: "TeamName",
                principalTable: "team",
                principalColumn: "Name",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_team_team_TeamName",
                table: "team",
                column: "TeamName",
                principalTable: "team",
                principalColumn: "Name");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_player_team_TeamName",
                table: "player");

            migrationBuilder.DropForeignKey(
                name: "FK_team_team_TeamName",
                table: "team");

            migrationBuilder.DropIndex(
                name: "IX_team_TeamName",
                table: "team");

            migrationBuilder.DropIndex(
                name: "IX_player_TeamName",
                table: "player");

            migrationBuilder.DropColumn(
                name: "TeamName",
                table: "team");

            migrationBuilder.DropColumn(
                name: "TeamName",
                table: "player");
        }
    }
}
