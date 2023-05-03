using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KLC_API.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MatningarNews2",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PatientId = table.Column<int>(type: "int", nullable: false),
                    Andningsfrekvens = table.Column<int>(type: "int", nullable: true),
                    SyreMattnad = table.Column<int>(type: "int", nullable: true),
                    TillfordSyrgas = table.Column<int>(type: "int", nullable: true),
                    SystolisktBlodtryck = table.Column<int>(type: "int", nullable: true),
                    Pulsfrekvens = table.Column<int>(type: "int", nullable: true),
                    Medvetandegrad = table.Column<int>(type: "int", nullable: true),
                    Temperatur = table.Column<int>(type: "int", nullable: true),
                    TidForMatning = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MatningarNews2", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Patienter",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Personnummer = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Patienter", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MatningarNews2");

            migrationBuilder.DropTable(
                name: "Patienter");
        }
    }
}
