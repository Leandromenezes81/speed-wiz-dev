using ExercicioBiblioteca.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExercicioBiblioteca.Mapping
{
    public class EmprestimoItemMapping : IEntityTypeConfiguration<ItensEmprestimo>
    {
        public void Configure(EntityTypeBuilder<ItensEmprestimo> builder)
        {
            builder.HasKey(x => x.CodigoItem);
            builder.HasOne(x => x.Emprestimo)
                   .WithMany(x => x.Itens)
                   .HasForeignKey(x => x.NumeroEmprestimo);
            builder.HasOne(x => x.Livro)
                   .WithMany()
                   .HasForeignKey(x => x.CodigoLivro);
            builder.ToTable("emprestimos_itens");
        }
    }
}
