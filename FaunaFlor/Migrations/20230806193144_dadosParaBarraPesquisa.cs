using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FaunaFlor.Migrations
{
    public partial class dadosParaBarraPesquisa : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AnimalId1",
                table: "Animais",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SearchString",
                table: "Animais",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_Animais_AnimalId1",
                table: "Animais",
                column: "AnimalId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Animais_Animais_AnimalId1",
                table: "Animais",
                column: "AnimalId1",
                principalTable: "Animais",
                principalColumn: "AnimalId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Animais_Animais_AnimalId1",
                table: "Animais");

            migrationBuilder.DropIndex(
                name: "IX_Animais_AnimalId1",
                table: "Animais");

            migrationBuilder.DropColumn(
                name: "AnimalId1",
                table: "Animais");

            migrationBuilder.DropColumn(
                name: "SearchString",
                table: "Animais");
        }
    }
}
