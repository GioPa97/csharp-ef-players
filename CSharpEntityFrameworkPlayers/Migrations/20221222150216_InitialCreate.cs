using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CSharpEntityFrameworkPlayers.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "player",
                columns: table => new
                {
                    PlayerID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MatchAttended = table.Column<int>(type: "int", nullable: false),
                    MatchWon = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Surname = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_player", x => x.PlayerID);
                });

            migrationBuilder.CreateTable(
                name: "team",
                columns: table => new
                {
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Coach = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Colours = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_team", x => x.Name);
                });

            migrationBuilder.CreateIndex(
                name: "IX_player_PlayerID",
                table: "player",
                column: "PlayerID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_team_Name",
                table: "team",
                column: "Name",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "player");

            migrationBuilder.DropTable(
                name: "team");
        }
    }
}
