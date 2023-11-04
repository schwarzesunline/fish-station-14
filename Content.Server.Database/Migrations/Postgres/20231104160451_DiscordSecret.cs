using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Content.Server.Database.Migrations.Postgres
{
    /// <inheritdoc />
    public partial class DiscordSecret : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "discord_refresh_token",
                table: "player",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "discord_secret",
                table: "player",
                type: "text",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "discord_refresh_token",
                table: "player");

            migrationBuilder.DropColumn(
                name: "discord_secret",
                table: "player");
        }
    }
}
