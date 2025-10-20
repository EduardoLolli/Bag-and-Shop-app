using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Bag_and_Shop_app.Migrations
{
    /// <inheritdoc />
    public partial class tentativaDeCorreçãoDoCharacter : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Characters_Bags_BagId1",
                table: "Characters");

            migrationBuilder.DropForeignKey(
                name: "FK_Characters_Bodys_BodyId1",
                table: "Characters");

            migrationBuilder.DropIndex(
                name: "IX_Characters_BagId1",
                table: "Characters");

            migrationBuilder.DropIndex(
                name: "IX_Characters_BodyId1",
                table: "Characters");

            migrationBuilder.DropColumn(
                name: "BagId1",
                table: "Characters");

            migrationBuilder.DropColumn(
                name: "BodyId1",
                table: "Characters");

            migrationBuilder.CreateIndex(
                name: "IX_Characters_BagId",
                table: "Characters",
                column: "BagId");

            migrationBuilder.CreateIndex(
                name: "IX_Characters_BodyId",
                table: "Characters",
                column: "BodyId");

            migrationBuilder.AddForeignKey(
                name: "FK_Characters_Bags_BagId",
                table: "Characters",
                column: "BagId",
                principalTable: "Bags",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Characters_Bodys_BodyId",
                table: "Characters",
                column: "BodyId",
                principalTable: "Bodys",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Characters_Bags_BagId",
                table: "Characters");

            migrationBuilder.DropForeignKey(
                name: "FK_Characters_Bodys_BodyId",
                table: "Characters");

            migrationBuilder.DropIndex(
                name: "IX_Characters_BagId",
                table: "Characters");

            migrationBuilder.DropIndex(
                name: "IX_Characters_BodyId",
                table: "Characters");

            migrationBuilder.AddColumn<int>(
                name: "BagId1",
                table: "Characters",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "BodyId1",
                table: "Characters",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Characters_BagId1",
                table: "Characters",
                column: "BagId1");

            migrationBuilder.CreateIndex(
                name: "IX_Characters_BodyId1",
                table: "Characters",
                column: "BodyId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Characters_Bags_BagId1",
                table: "Characters",
                column: "BagId1",
                principalTable: "Bags",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Characters_Bodys_BodyId1",
                table: "Characters",
                column: "BodyId1",
                principalTable: "Bodys",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
