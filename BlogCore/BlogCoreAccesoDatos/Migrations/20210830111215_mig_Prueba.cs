using Microsoft.EntityFrameworkCore.Migrations;

namespace BlogCoreAccesoDatos.Migrations
{
    public partial class mig_Prueba : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "CategoriaId",
                table: "Articulo",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Articulo_CategoriaId",
                table: "Articulo",
                column: "CategoriaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Articulo_Categoria_CategoriaId",
                table: "Articulo",
                column: "CategoriaId",
                principalTable: "Categoria",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Articulo_Categoria_CategoriaId",
                table: "Articulo");

            migrationBuilder.DropIndex(
                name: "IX_Articulo_CategoriaId",
                table: "Articulo");

            migrationBuilder.AlterColumn<string>(
                name: "CategoriaId",
                table: "Articulo",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int));
        }
    }
}
