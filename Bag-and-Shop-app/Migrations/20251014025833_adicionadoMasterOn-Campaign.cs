using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Bag_and_Shop_app.Migrations
{
    /// <inheritdoc />
    public partial class adicionadoMasterOnCampaign : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "MasterId",
                table: "Campaigns",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Campaigns_MasterId",
                table: "Campaigns",
                column: "MasterId");

            migrationBuilder.AddForeignKey(
                name: "FK_Campaigns_Users_MasterId",
                table: "Campaigns",
                column: "MasterId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Campaigns_Users_MasterId",
                table: "Campaigns");

            migrationBuilder.DropIndex(
                name: "IX_Campaigns_MasterId",
                table: "Campaigns");

            migrationBuilder.DropColumn(
                name: "MasterId",
                table: "Campaigns");
        }
    }
}
