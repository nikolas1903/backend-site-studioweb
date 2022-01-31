using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class CHANGE_ORCAMENTO_SIZE_EMAIL : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Sugestao",
                table: "Orcamento",
                type: "nvarchar(350)",
                maxLength: 350,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(150)",
                oldMaxLength: 150);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Orcamento",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(25)",
                oldMaxLength: 25);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Sugestao",
                table: "Orcamento",
                type: "nvarchar(150)",
                maxLength: 150,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(350)",
                oldMaxLength: 350);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Orcamento",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);
        }
    }
}
