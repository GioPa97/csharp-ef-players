using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CSharpEntityFrameworkPlayers.Migrations
{
    /// <inheritdoc />
    public partial class Revisione : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_player_team_TeamName",
                table: "player");

            migrationBuilder.DropForeignKey(
                name: "FK_team_team_TeamName",
                table: "team");

            migrationBuilder.DropPrimaryKey(
                name: "PK_team",
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

            migrationBuilder.AddColumn<int>(
                name: "TeamId",
                table: "team",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "TeamID",
                table: "player",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_team",
                table: "team",
                column: "TeamId");

            migrationBuilder.CreateIndex(
                name: "IX_player_TeamID",
                table: "player",
                column: "TeamID");

            migrationBuilder.AddForeignKey(
                name: "FK_player_team_TeamID",
                table: "player",
                column: "TeamID",
                principalTable: "team",
                principalColumn: "TeamId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_player_team_TeamID",
                table: "player");

            migrationBuilder.DropPrimaryKey(
                name: "PK_team",
                table: "team");

            migrationBuilder.DropIndex(
                name: "IX_player_TeamID",
                table: "player");

            migrationBuilder.DropColumn(
                name: "TeamId",
                table: "team");

            migrationBuilder.DropColumn(
                name: "TeamID",
                table: "player");

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

            migrationBuilder.AddPrimaryKey(
                name: "PK_team",
                table: "team",
                column: "Name");

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
    }
}
