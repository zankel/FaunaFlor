using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FaunaFlor.Migrations
{
    public partial class adicaoDescricaoMaisExtensa : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "DescricaoPrincipal",
                table: "Habitats",
                type: "longtext",
                maxLength: 2147483647,
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "Descricao",
                table: "Animais",
                type: "varchar(300)",
                maxLength: 300,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "DescricaoPrincipal",
                table: "Animais",
                type: "longtext",
                maxLength: 2147483647,
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DescricaoPrincipal",
                table: "Habitats");

            migrationBuilder.DropColumn(
                name: "DescricaoPrincipal",
                table: "Animais");

            migrationBuilder.AlterColumn<string>(
                name: "Descricao",
                table: "Animais",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(300)",
                oldMaxLength: 300)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");
        }
    }
}
