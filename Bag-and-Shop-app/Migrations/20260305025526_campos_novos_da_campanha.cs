using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Bag_and_Shop_app.Migrations
{
    /// <inheritdoc />
    public partial class campos_novos_da_campanha : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "StoreId",
                table: "Campaigns",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Store",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CampaignId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Store", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Store_Campaigns_CampaignId",
                        column: x => x.CampaignId,
                        principalTable: "Campaigns",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "systemFields",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SystemId = table.Column<int>(type: "int", nullable: false),
                    Field_name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Field_value = table.Column<int>(type: "int", nullable: false),
                    Field_type = table.Column<int>(type: "int", nullable: false),
                    Default_value = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_systemFields", x => x.Id);
                    table.ForeignKey(
                        name: "FK_systemFields_SystemEntities_SystemId",
                        column: x => x.SystemId,
                        principalTable: "SystemEntities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Campaigns_StoreId",
                table: "Campaigns",
                column: "StoreId");

            migrationBuilder.CreateIndex(
                name: "IX_Store_CampaignId",
                table: "Store",
                column: "CampaignId");

            migrationBuilder.CreateIndex(
                name: "IX_systemFields_SystemId",
                table: "systemFields",
                column: "SystemId");

            migrationBuilder.AddForeignKey(
                name: "FK_Campaigns_Store_StoreId",
                table: "Campaigns",
                column: "StoreId",
                principalTable: "Store",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Campaigns_Store_StoreId",
                table: "Campaigns");

            migrationBuilder.DropTable(
                name: "Store");

            migrationBuilder.DropTable(
                name: "systemFields");

            migrationBuilder.DropIndex(
                name: "IX_Campaigns_StoreId",
                table: "Campaigns");

            migrationBuilder.DropColumn(
                name: "StoreId",
                table: "Campaigns");
        }
    }
}
