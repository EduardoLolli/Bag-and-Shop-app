using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Bag_and_Shop_app.Migrations
{
    /// <inheritdoc />
    public partial class alteradaModelagemDeInventario : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Characters_Bags_BagId",
                table: "Characters");

            migrationBuilder.DropForeignKey(
                name: "FK_Characters_Bodys_BodyId",
                table: "Characters");

            migrationBuilder.DropForeignKey(
                name: "FK_Items_Bags_BagId",
                table: "Items");

            migrationBuilder.DropForeignKey(
                name: "FK_Items_Stores_StoreId",
                table: "Items");

            migrationBuilder.DropIndex(
                name: "IX_Items_BagId",
                table: "Items");

            migrationBuilder.DropIndex(
                name: "IX_Items_StoreId",
                table: "Items");

            migrationBuilder.DropIndex(
                name: "IX_Characters_BagId",
                table: "Characters");

            migrationBuilder.DropIndex(
                name: "IX_Characters_BodyId",
                table: "Characters");

            migrationBuilder.DropColumn(
                name: "BagId",
                table: "Items");

            migrationBuilder.DropColumn(
                name: "LojaId",
                table: "Items");

            migrationBuilder.DropColumn(
                name: "StoreId",
                table: "Items");

            migrationBuilder.DropColumn(
                name: "BagId",
                table: "Characters");

            migrationBuilder.DropColumn(
                name: "BodyId",
                table: "Characters");

            migrationBuilder.DropColumn(
                name: "Gold",
                table: "Characters");

            migrationBuilder.RenameColumn(
                name: "Quantidade",
                table: "StoreItems",
                newName: "Quantity");

            migrationBuilder.RenameColumn(
                name: "PrecoVenda",
                table: "StoreItems",
                newName: "Price");

            migrationBuilder.RenameColumn(
                name: "Status",
                table: "Items",
                newName: "Rarity");

            migrationBuilder.RenameColumn(
                name: "Quantidade",
                table: "BagItems",
                newName: "Quantity");

            migrationBuilder.RenameColumn(
                name: "Condicao",
                table: "BagItems",
                newName: "Condition");

            migrationBuilder.AddColumn<int>(
                name: "AttributeBonus",
                table: "Items",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "AttributeDebuff",
                table: "Items",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "DiceRoll",
                table: "Items",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "IconPath",
                table: "Items",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "IsStackable",
                table: "Items",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "MaxStackSize",
                table: "Items",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<double>(
                name: "CurrentWeight",
                table: "Bags",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<decimal>(
                name: "Gold",
                table: "Bags",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<double>(
                name: "WeightLimit",
                table: "Bags",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.CreateIndex(
                name: "IX_Bodys_CharacterId",
                table: "Bodys",
                column: "CharacterId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Bags_CharacterId",
                table: "Bags",
                column: "CharacterId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Bags_Characters_CharacterId",
                table: "Bags",
                column: "CharacterId",
                principalTable: "Characters",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Bodys_Characters_CharacterId",
                table: "Bodys",
                column: "CharacterId",
                principalTable: "Characters",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bags_Characters_CharacterId",
                table: "Bags");

            migrationBuilder.DropForeignKey(
                name: "FK_Bodys_Characters_CharacterId",
                table: "Bodys");

            migrationBuilder.DropIndex(
                name: "IX_Bodys_CharacterId",
                table: "Bodys");

            migrationBuilder.DropIndex(
                name: "IX_Bags_CharacterId",
                table: "Bags");

            migrationBuilder.DropColumn(
                name: "AttributeBonus",
                table: "Items");

            migrationBuilder.DropColumn(
                name: "AttributeDebuff",
                table: "Items");

            migrationBuilder.DropColumn(
                name: "DiceRoll",
                table: "Items");

            migrationBuilder.DropColumn(
                name: "IconPath",
                table: "Items");

            migrationBuilder.DropColumn(
                name: "IsStackable",
                table: "Items");

            migrationBuilder.DropColumn(
                name: "MaxStackSize",
                table: "Items");

            migrationBuilder.DropColumn(
                name: "CurrentWeight",
                table: "Bags");

            migrationBuilder.DropColumn(
                name: "Gold",
                table: "Bags");

            migrationBuilder.DropColumn(
                name: "WeightLimit",
                table: "Bags");

            migrationBuilder.RenameColumn(
                name: "Quantity",
                table: "StoreItems",
                newName: "Quantidade");

            migrationBuilder.RenameColumn(
                name: "Price",
                table: "StoreItems",
                newName: "PrecoVenda");

            migrationBuilder.RenameColumn(
                name: "Rarity",
                table: "Items",
                newName: "Status");

            migrationBuilder.RenameColumn(
                name: "Quantity",
                table: "BagItems",
                newName: "Quantidade");

            migrationBuilder.RenameColumn(
                name: "Condition",
                table: "BagItems",
                newName: "Condicao");

            migrationBuilder.AddColumn<int>(
                name: "BagId",
                table: "Items",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "LojaId",
                table: "Items",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "StoreId",
                table: "Items",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "BagId",
                table: "Characters",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "BodyId",
                table: "Characters",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<decimal>(
                name: "Gold",
                table: "Characters",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.CreateIndex(
                name: "IX_Items_BagId",
                table: "Items",
                column: "BagId");

            migrationBuilder.CreateIndex(
                name: "IX_Items_StoreId",
                table: "Items",
                column: "StoreId");

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

            migrationBuilder.AddForeignKey(
                name: "FK_Items_Bags_BagId",
                table: "Items",
                column: "BagId",
                principalTable: "Bags",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Items_Stores_StoreId",
                table: "Items",
                column: "StoreId",
                principalTable: "Stores",
                principalColumn: "Id");
        }
    }
}
