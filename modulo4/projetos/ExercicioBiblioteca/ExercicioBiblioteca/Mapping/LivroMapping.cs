using ExercicioBiblioteca.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExercicioBiblioteca.Mapping
{
    // Mapeamento (e configuração) da tabela 'livro'
    public class LivroMapping : IEntityTypeConfiguration<Livro>
    {
        public void Configure(EntityTypeBuilder<Livro> builder)
        {
            // HasKey = PrimaryKey
            builder.HasKey(x => x.Codigo);
            // HasColumnType = Tamanho do campo; .IsRequired = NOT NULL
            builder.Property(x => x.Descricao).HasColumnType("VARCHAR(60)").IsRequired();
            builder.Property(x => x.ISBN).IsRequired();
            builder.Property(x => x.AnoLancamento).IsRequired();
            // FOREIGN KEY(CodigoAutor) REFERENCES autor(Codigo).
            builder.HasOne(x => x.Autor)
                   .WithMany()
                   .HasForeignKey(x => x.CodigoAutor);
            builder.Property(x => x.CodigoEditora).HasColumnType("VARCHAR(60)").IsRequired(false);
            // Nome que a tabela terá no DB.
            builder.ToTable("livros");

        }
    }
}
