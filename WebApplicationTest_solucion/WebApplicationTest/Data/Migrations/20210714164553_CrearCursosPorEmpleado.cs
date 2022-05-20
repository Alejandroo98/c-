using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplicationTest.Data.Migrations
{
    public partial class CrearCursosPorEmpleado : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cursos",
                columns: table => new
                {
                    CursoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NumeroEnteros = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cursos", x => x.CursoId);
                });

            migrationBuilder.CreateTable(
                name: "CursoEmpleado",
                columns: table => new
                {
                    CursosCursoId = table.Column<int>(type: "int", nullable: false),
                    ParticipantesEmpleadoid = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CursoEmpleado", x => new { x.CursosCursoId, x.ParticipantesEmpleadoid });
                    table.ForeignKey(
                        name: "FK_CursoEmpleado_Cursos_CursosCursoId",
                        column: x => x.CursosCursoId,
                        principalTable: "Cursos",
                        principalColumn: "CursoId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CursoEmpleado_Empleados_ParticipantesEmpleadoid",
                        column: x => x.ParticipantesEmpleadoid,
                        principalTable: "Empleados",
                        principalColumn: "Empleadoid",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CursoEmpleado_ParticipantesEmpleadoid",
                table: "CursoEmpleado",
                column: "ParticipantesEmpleadoid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CursoEmpleado");

            migrationBuilder.DropTable(
                name: "Cursos");
        }
    }
}
