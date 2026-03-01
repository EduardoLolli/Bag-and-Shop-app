using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Bag_and_Shop_app.Migrations
{
    /// <inheritdoc />
    public partial class adicionando_migration_de_novos_itens : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "campaignId",
                table: "Items",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "systemEntityId",
                table: "Items",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Items_campaignId",
                table: "Items",
                column: "campaignId");

            migrationBuilder.CreateIndex(
                name: "IX_Items_systemEntityId",
                table: "Items",
                column: "systemEntityId");

            migrationBuilder.AddForeignKey(
                name: "FK_Items_Campaigns_campaignId",
                table: "Items",
                column: "campaignId",
                principalTable: "Campaigns",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Items_SystemEntities_systemEntityId",
                table: "Items",
                column: "systemEntityId",
                principalTable: "SystemEntities",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Items_Campaigns_campaignId",
                table: "Items");

            migrationBuilder.DropForeignKey(
                name: "FK_Items_SystemEntities_systemEntityId",
                table: "Items");

            migrationBuilder.DropIndex(
                name: "IX_Items_campaignId",
                table: "Items");

            migrationBuilder.DropIndex(
                name: "IX_Items_systemEntityId",
                table: "Items");

            migrationBuilder.DropColumn(
                name: "campaignId",
                table: "Items");

            migrationBuilder.DropColumn(
                name: "systemEntityId",
                table: "Items");
        }
    }
}
