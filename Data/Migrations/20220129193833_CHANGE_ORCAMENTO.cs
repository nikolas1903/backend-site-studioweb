using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class CHANGE_ORCAMENTO : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Sugestao",
                table: "Orcamento",
                type: "nvarchar(150)",
                maxLength: 150,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(2)",
                oldMaxLength: 2);

            migrationBuilder.AlterColumn<string>(
                name: "NomeEmpresa",
                table: "Orcamento",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(2)",
                oldMaxLength: 2);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Sugestao",
                table: "Orcamento",
                type: "nvarchar(2)",
                maxLength: 2,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(150)",
                oldMaxLength: 150);

            migrationBuilder.AlterColumn<string>(
                name: "NomeEmpresa",
                table: "Orcamento",
                type: "nvarchar(2)",
                maxLength: 2,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);
        }
    }
}
