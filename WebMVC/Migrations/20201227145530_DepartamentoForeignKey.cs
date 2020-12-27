using Microsoft.EntityFrameworkCore.Migrations;

namespace WebMVC.Migrations
{
    public partial class DepartamentoForeignKey : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_registroVenda_Vendedor_VendedorId",
                table: "registroVenda");

            migrationBuilder.DropForeignKey(
                name: "FK_Vendedor_Departamento_DepartamentoId",
                table: "Vendedor");

            migrationBuilder.DropPrimaryKey(
                name: "PK_registroVenda",
                table: "registroVenda");

            migrationBuilder.RenameTable(
                name: "registroVenda",
                newName: "RegistroVenda");

            migrationBuilder.RenameIndex(
                name: "IX_registroVenda_VendedorId",
                table: "RegistroVenda",
                newName: "IX_RegistroVenda_VendedorId");

            migrationBuilder.AlterColumn<int>(
                name: "DepartamentoId",
                table: "Vendedor",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_RegistroVenda",
                table: "RegistroVenda",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_RegistroVenda_Vendedor_VendedorId",
                table: "RegistroVenda",
                column: "VendedorId",
                principalTable: "Vendedor",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Vendedor_Departamento_DepartamentoId",
                table: "Vendedor",
                column: "DepartamentoId",
                principalTable: "Departamento",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RegistroVenda_Vendedor_VendedorId",
                table: "RegistroVenda");

            migrationBuilder.DropForeignKey(
                name: "FK_Vendedor_Departamento_DepartamentoId",
                table: "Vendedor");

            migrationBuilder.DropPrimaryKey(
                name: "PK_RegistroVenda",
                table: "RegistroVenda");

            migrationBuilder.RenameTable(
                name: "RegistroVenda",
                newName: "registroVenda");

            migrationBuilder.RenameIndex(
                name: "IX_RegistroVenda_VendedorId",
                table: "registroVenda",
                newName: "IX_registroVenda_VendedorId");

            migrationBuilder.AlterColumn<int>(
                name: "DepartamentoId",
                table: "Vendedor",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddPrimaryKey(
                name: "PK_registroVenda",
                table: "registroVenda",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_registroVenda_Vendedor_VendedorId",
                table: "registroVenda",
                column: "VendedorId",
                principalTable: "Vendedor",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Vendedor_Departamento_DepartamentoId",
                table: "Vendedor",
                column: "DepartamentoId",
                principalTable: "Departamento",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
