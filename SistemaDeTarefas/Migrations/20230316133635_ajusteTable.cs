using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SistemaDeTarefas.Migrations
{
    public partial class ajusteTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Terefas_Usuarios_UsuarioId",
                table: "Terefas");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Terefas",
                table: "Terefas");

            migrationBuilder.RenameTable(
                name: "Terefas",
                newName: "Tarefas");

            migrationBuilder.RenameIndex(
                name: "IX_Terefas_UsuarioId",
                table: "Tarefas",
                newName: "IX_Tarefas_UsuarioId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Tarefas",
                table: "Tarefas",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Tarefas_Usuarios_UsuarioId",
                table: "Tarefas",
                column: "UsuarioId",
                principalTable: "Usuarios",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tarefas_Usuarios_UsuarioId",
                table: "Tarefas");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Tarefas",
                table: "Tarefas");

            migrationBuilder.RenameTable(
                name: "Tarefas",
                newName: "Tarefas");

            migrationBuilder.RenameIndex(
                name: "IX_Tarefas_UsuarioId",
                table: "Tarefas",
                newName: "IX_Terefas_UsuarioId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Terefas",
                table: "Tarefas",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Terefas_Usuarios_UsuarioId",
                table: "Tarefas",
                column: "UsuarioId",
                principalTable: "Usuarios",
                principalColumn: "Id");
        }
    }
}
