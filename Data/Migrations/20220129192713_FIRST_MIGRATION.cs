using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class FIRST_MIGRATION : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Orcamento",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Cpf = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Telefone = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    Ramo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    NomeEmpresa = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: false),
                    Templates = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Sugestao = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: false),
                    Situacao = table.Column<int>(type: "int", nullable: false),
                    DataCriacao = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orcamento", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Usuario",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Login = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Cpf = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    Senha = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    Ativo = table.Column<int>(type: "int", maxLength: 2, nullable: false),
                    DataCriacao = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuario", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Orcamento");

            migrationBuilder.DropTable(
                name: "Usuario");
        }
    }
}
