using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistencia.Migrations
{
    public partial class AgregarTablaConsola4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Almacenamiento",
                table: "Consolas",
                newName: "TipoAlmacenamiento");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "TipoAlmacenamiento",
                table: "Consolas",
                newName: "Almacenamiento");
        }
    }
}
