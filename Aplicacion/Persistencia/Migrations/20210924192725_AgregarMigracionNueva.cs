using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistencia.Migrations
{
    public partial class AgregarMigracionNueva : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Empleados_Roles_RolEmpleadoId",
                table: "Empleados");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropIndex(
                name: "IX_Empleados_RolEmpleadoId",
                table: "Empleados");

            migrationBuilder.DropColumn(
                name: "RolEmpleadoId",
                table: "Empleados");

            migrationBuilder.AddColumn<bool>(
                name: "AccesoReportes",
                table: "Empleados",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "NombreRol",
                table: "Empleados",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Password",
                table: "Empleados",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AccesoReportes",
                table: "Empleados");

            migrationBuilder.DropColumn(
                name: "NombreRol",
                table: "Empleados");

            migrationBuilder.DropColumn(
                name: "Password",
                table: "Empleados");

            migrationBuilder.AddColumn<int>(
                name: "RolEmpleadoId",
                table: "Empleados",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CodigoRol = table.Column<int>(type: "int", nullable: false),
                    NombreRol = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Empleados_RolEmpleadoId",
                table: "Empleados",
                column: "RolEmpleadoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Empleados_Roles_RolEmpleadoId",
                table: "Empleados",
                column: "RolEmpleadoId",
                principalTable: "Roles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
