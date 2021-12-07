using ExercicioBiblioteca.Models;
using Microsoft.EntityFrameworkCore;

namespace ExercicioBiblioteca.Context
{
    /*
     * Classe de contexto responsável por criar as entidades do banco de dados e
     * encaminhar o mapeamento, ou seja, a determinação dos tipos de campos das 
     * tabelas. Esse mapeamento será feito em 'Dbsets' separados contidos no di-
     * retório 'Mapping'. O mapeamento é feito consoante as propriedades criadas
     * em cada classe do diretório 'Models'.
     */

    public class BibliotecaDbContext : DbContext
    {
        #region DbSets
        // Entidades (tabelas) do banco de dados.
        public DbSet<Livro> Livros { get; set; }
        public DbSet<Autor> Autores { get; set; }
        public DbSet<Leitor> Leitores { get; set; }
        public DbSet<Emprestimo> Emprestimos { get; set; }
        public DbSet<ItensEmprestimo> ItensEmprestimos { get; set; } 
        #endregion


        #region Construtor
        public BibliotecaDbContext(DbContextOptions options) : base(options)
        {
        }
        #endregion

        // Método para configuração das propriedades das tabelas.
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Determinando a busca por todos os arquivos de configuração determinados no Assembly
            // (ExercicioBiblioteca) e seus diretórios para a criação do DB.
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(BibliotecaDbContext).Assembly);
            base.OnModelCreating(modelBuilder);
        }
    }
}
