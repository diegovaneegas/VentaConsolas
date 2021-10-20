using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistencia.Migrations
{
    public partial class AgregarTablaControles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "VideoJuegoId",
                table: "Consolas",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Controles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Serial = table.Column<int>(type: "int", nullable: false),
                    FechaCompra = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    precioCompra = table.Column<int>(type: "int", nullable: false),
                    precioVenta = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Controles", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Consolas_VideoJuegoId",
                table: "Consolas",
                column: "VideoJuegoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Consolas_VideoJuego_VideoJuegoId",
                table: "Consolas",
                column: "VideoJuegoId",
                principalTable: "VideoJuego",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Consolas_VideoJuego_VideoJuegoId",
                table: "Consolas");

            migrationBuilder.DropTable(
                name: "Controles");

            migrationBuilder.DropIndex(
                name: "IX_Consolas_VideoJuegoId",
                table: "Consolas");

            migrationBuilder.DropColumn(
                name: "VideoJuegoId",
                table: "Consolas");
        }
    }
}
