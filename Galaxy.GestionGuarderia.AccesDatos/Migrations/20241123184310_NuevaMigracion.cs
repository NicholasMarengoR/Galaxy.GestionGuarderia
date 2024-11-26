using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Galaxy.GestionGuarderia.AccesDatos.Migrations
{
    /// <inheritdoc />
    public partial class NuevaMigracion : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categoria",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Estado = table.Column<bool>(type: "bit", nullable: false),
                    FechaCreacion = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categoria", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Cliente",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre1 = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Nombre2 = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Apellido1 = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Apellido2 = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Correo = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Celular = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Departamento = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Provincia = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Distrito = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Nacionalidad = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    FechaNacimiento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaInscripcion = table.Column<DateTime>(type: "DATE", nullable: false),
                    Estado = table.Column<bool>(type: "bit", nullable: false),
                    FechaCreacion = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cliente", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Cuidador",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombres = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    NroDocumento = table.Column<string>(type: "nvarchar(11)", maxLength: 11, nullable: false),
                    CategoriaId = table.Column<int>(type: "int", nullable: false),
                    Estado = table.Column<bool>(type: "bit", nullable: false),
                    FechaCreacion = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cuidador", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Cuidador_Categoria_CategoriaId",
                        column: x => x.CategoriaId,
                        principalTable: "Categoria",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Modulo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    CategoriaId = table.Column<int>(type: "int", nullable: false),
                    CuidadorId = table.Column<int>(type: "int", nullable: false),
                    FechaInicio = table.Column<DateTime>(type: "DATE", nullable: false),
                    HoraInicio = table.Column<DateTime>(type: "DATETIME", nullable: false),
                    PortadaURL = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    TemarioURL = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    Descripcion = table.Column<string>(type: "nvarchar(700)", maxLength: 700, nullable: false),
                    Situacion = table.Column<int>(type: "int", nullable: false),
                    Estado = table.Column<bool>(type: "bit", nullable: false),
                    FechaCreacion = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Modulo", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Modulo_Categoria_CategoriaId",
                        column: x => x.CategoriaId,
                        principalTable: "Categoria",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Modulo_Cuidador_CuidadorId",
                        column: x => x.CuidadorId,
                        principalTable: "Cuidador",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Inscripcion",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClienteID = table.Column<int>(type: "int", nullable: false),
                    ModuloId = table.Column<int>(type: "int", nullable: false),
                    Situacion = table.Column<int>(type: "int", nullable: false),
                    Estado = table.Column<bool>(type: "bit", nullable: false),
                    FechaCreacion = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Inscripcion", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Inscripcion_Cliente_ClienteID",
                        column: x => x.ClienteID,
                        principalTable: "Cliente",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Inscripcion_Modulo_ModuloId",
                        column: x => x.ModuloId,
                        principalTable: "Modulo",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "Categoria",
                columns: new[] { "Id", "Estado", "FechaCreacion", "Nombre" },
                values: new object[,]
                {
                    { 1, true, new DateTime(2024, 11, 23, 18, 43, 9, 727, DateTimeKind.Utc).AddTicks(6217), "Sala menos de 1 año" },
                    { 2, true, new DateTime(2024, 11, 23, 18, 43, 9, 727, DateTimeKind.Utc).AddTicks(7075), "Sala 1 a 2 años" },
                    { 3, true, new DateTime(2024, 11, 23, 18, 43, 9, 727, DateTimeKind.Utc).AddTicks(7163), "Sala 2 a 3 años" },
                    { 4, true, new DateTime(2024, 11, 23, 18, 43, 9, 727, DateTimeKind.Utc).AddTicks(7165), "Sala jardin" },
                    { 5, true, new DateTime(2024, 11, 23, 18, 43, 9, 727, DateTimeKind.Utc).AddTicks(7166), "Sala multiuso" },
                    { 6, true, new DateTime(2024, 11, 23, 18, 43, 9, 727, DateTimeKind.Utc).AddTicks(7176), "Comedor" },
                    { 7, true, new DateTime(2024, 11, 23, 18, 43, 9, 727, DateTimeKind.Utc).AddTicks(7178), "Sala descanso" },
                    { 8, true, new DateTime(2024, 11, 23, 18, 43, 9, 727, DateTimeKind.Utc).AddTicks(7179), "Sala de espera" },
                    { 9, true, new DateTime(2024, 11, 23, 18, 43, 9, 727, DateTimeKind.Utc).AddTicks(7180), "Administracion" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Cuidador_CategoriaId",
                table: "Cuidador",
                column: "CategoriaId");

            migrationBuilder.CreateIndex(
                name: "IX_Cuidador_NroDocumento",
                table: "Cuidador",
                column: "NroDocumento");

            migrationBuilder.CreateIndex(
                name: "IX_Inscripcion_ClienteID",
                table: "Inscripcion",
                column: "ClienteID");

            migrationBuilder.CreateIndex(
                name: "IX_Inscripcion_ModuloId",
                table: "Inscripcion",
                column: "ModuloId");

            migrationBuilder.CreateIndex(
                name: "IX_Modulo_CategoriaId",
                table: "Modulo",
                column: "CategoriaId");

            migrationBuilder.CreateIndex(
                name: "IX_Modulo_CuidadorId",
                table: "Modulo",
                column: "CuidadorId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Inscripcion");

            migrationBuilder.DropTable(
                name: "Cliente");

            migrationBuilder.DropTable(
                name: "Modulo");

            migrationBuilder.DropTable(
                name: "Cuidador");

            migrationBuilder.DropTable(
                name: "Categoria");
        }
    }
}
