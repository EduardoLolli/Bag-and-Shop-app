using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Bag_and_Shop_app.Migrations
{
    /// <inheritdoc />
    public partial class adicionandoCampoDeLimiteDePlayersNaCampanha : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PlayersLimit",
                table: "Campaigns",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PlayersLimit",
                table: "Campaigns");
        }
    }
}
