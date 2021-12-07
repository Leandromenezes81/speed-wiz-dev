using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ExercicioBiblioteca.Migrations
{
    public partial class TabelasIniciais : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "autores",
                columns: table => new
                {
                    Codigo = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "VARCHAR(60)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_autores", x => x.Codigo);
                });

            migrationBuilder.CreateTable(
                name: "leitores",
                columns: table => new
                {
                    Codigo = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "VARCHAR(60)", nullable: false),
                    CPF = table.Column<int>(nullable: false),
                    Email = table.Column<string>(type: "VARCHAR(255)", nullable: true),
                    Telefone = table.Column<string>(type: "VARCHAR(15)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_leitores", x => x.Codigo);
                });

            migrationBuilder.CreateTable(
                name: "livros",
                columns: table => new
                {
                    Codigo = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descricao = table.Column<string>(type: "VARCHAR(60)", nullable: false),
                    ISBN = table.Column<int>(nullable: false),
                    AnoLancamento = table.Column<int>(nullable: false),
                    CodigoAutor = table.Column<int>(nullable: false),
                    CodigoEditora = table.Column<string>(type: "VARCHAR(60)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_livros", x => x.Codigo);
                    table.ForeignKey(
                        name: "FK_livros_autores_CodigoAutor",
                        column: x => x.CodigoAutor,
                        principalTable: "autores",
                        principalColumn: "Codigo",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "emprestimos",
                columns: table => new
                {
                    Numero = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CodigoLeitor = table.Column<int>(nullable: false),
                    DataEmprestimo = table.Column<DateTime>(type: "datetime", nullable: false),
                    DataDevolucao = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_emprestimos", x => x.Numero);
                    table.ForeignKey(
                        name: "FK_emprestimos_leitores_CodigoLeitor",
                        column: x => x.CodigoLeitor,
                        principalTable: "leitores",
                        principalColumn: "Codigo",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "emprestimos_itens",
                columns: table => new
                {
                    CodigoItem = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NumeroEmprestimo = table.Column<int>(nullable: false),
                    CodigoLivro = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_emprestimos_itens", x => x.CodigoItem);
                    table.ForeignKey(
                        name: "FK_emprestimos_itens_livros_CodigoLivro",
                        column: x => x.CodigoLivro,
                        principalTable: "livros",
                        principalColumn: "Codigo",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_emprestimos_itens_emprestimos_NumeroEmprestimo",
                        column: x => x.NumeroEmprestimo,
                        principalTable: "emprestimos",
                        principalColumn: "Numero",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_emprestimos_CodigoLeitor",
                table: "emprestimos",
                column: "CodigoLeitor");

            migrationBuilder.CreateIndex(
                name: "IX_emprestimos_itens_CodigoLivro",
                table: "emprestimos_itens",
                column: "CodigoLivro");

            migrationBuilder.CreateIndex(
                name: "IX_emprestimos_itens_NumeroEmprestimo",
                table: "emprestimos_itens",
                column: "NumeroEmprestimo");

            migrationBuilder.CreateIndex(
                name: "IX_livros_CodigoAutor",
                table: "livros",
                column: "CodigoAutor");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "emprestimos_itens");

            migrationBuilder.DropTable(
                name: "livros");

            migrationBuilder.DropTable(
                name: "emprestimos");

            migrationBuilder.DropTable(
                name: "autores");

            migrationBuilder.DropTable(
                name: "leitores");
        }
    }
}
