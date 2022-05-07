using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ApiBugs.Migrations
{
    public partial class InicioProyecto : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BugsDb",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Reporta = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FechaReporte = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Resumen = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Url = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Pantalla = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Plataforma = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SistemaOperativo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    App = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Severidad = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Atiende = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Prioridad = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BugsDb", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BugsDb");
        }
    }
}
