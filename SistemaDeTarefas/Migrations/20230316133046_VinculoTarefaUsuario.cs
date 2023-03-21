using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SistemaDeTarefas.Migrations
{
    public partial class VinculoTarefaUsuario : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "UsuarioId",
                table: "Terefas",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Terefas_UsuarioId",
                table: "Terefas",
                column: "UsuarioId");

            migrationBuilder.AddForeignKey(
                name: "FK_Terefas_Usuarios_UsuarioId",
                table: "Terefas",
                column: "UsuarioId",
                principalTable: "Usuarios",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Terefas_Usuarios_UsuarioId",
                table: "Terefas");

            migrationBuilder.DropIndex(
                name: "IX_Terefas_UsuarioId",
                table: "Terefas");

            migrationBuilder.DropColumn(
                name: "UsuarioId",
                table: "Terefas");
        }
    }
}
