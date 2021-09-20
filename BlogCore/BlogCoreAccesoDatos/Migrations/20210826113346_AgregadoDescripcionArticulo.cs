using Microsoft.EntityFrameworkCore.Migrations;

namespace BlogCoreAccesoDatos.Migrations
{
    public partial class AgregadoDescripcionArticulo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Articulo_Categoria_CategoriaId",
                table: "Articulo");

            migrationBuilder.DropIndex(
                name: "IX_Articulo_CategoriaId",
                table: "Articulo");

            migrationBuilder.AlterColumn<string>(
                name: "UrlImagen",
                table: "Articulo",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "Nombre",
                table: "Articulo",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "FechaCreacion",
                table: "Articulo",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "CategoriaId",
                table: "Articulo",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<string>(
                name: "Descripcion",
                table: "Articulo",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Descripcion",
                table: "Articulo");

            migrationBuilder.AlterColumn<int>(
                name: "UrlImagen",
                table: "Articulo",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Nombre",
                table: "Articulo",
                type: "int",
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<int>(
                name: "FechaCreacion",
                table: "Articulo",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CategoriaId",
                table: "Articulo",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
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
    }
}
