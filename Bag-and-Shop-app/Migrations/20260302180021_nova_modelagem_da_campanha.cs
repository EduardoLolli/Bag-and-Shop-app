using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Bag_and_Shop_app.Migrations
{
    /// <inheritdoc />
    public partial class nova_modelagem_da_campanha : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "system_code",
                table: "SystemEntities",
                newName: "System_code");

            migrationBuilder.RenameColumn(
                name: "PlayersLimit",
                table: "Campaigns",
                newName: "System_id");

            migrationBuilder.RenameColumn(
                name: "CampaignCode",
                table: "Campaigns",
                newName: "Campaign_code");

            migrationBuilder.AddColumn<int>(
                name: "Attribute_definition",
                table: "Campaigns",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "Enable_multiclasses",
                table: "Campaigns",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Is_store_open",
                table: "Campaigns",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "Master_id",
                table: "Campaigns",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Players_limit",
                table: "Campaigns",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Attribute_definition",
                table: "Campaigns");

            migrationBuilder.DropColumn(
                name: "Enable_multiclasses",
                table: "Campaigns");

            migrationBuilder.DropColumn(
                name: "Is_store_open",
                table: "Campaigns");

            migrationBuilder.DropColumn(
                name: "Master_id",
                table: "Campaigns");

            migrationBuilder.DropColumn(
                name: "Players_limit",
                table: "Campaigns");

            migrationBuilder.RenameColumn(
                name: "System_code",
                table: "SystemEntities",
                newName: "system_code");

            migrationBuilder.RenameColumn(
                name: "System_id",
                table: "Campaigns",
                newName: "PlayersLimit");

            migrationBuilder.RenameColumn(
                name: "Campaign_code",
                table: "Campaigns",
                newName: "CampaignCode");
        }
    }
}
