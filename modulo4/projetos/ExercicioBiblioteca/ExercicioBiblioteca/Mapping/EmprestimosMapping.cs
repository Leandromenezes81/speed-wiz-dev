using ExercicioBiblioteca.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExercicioBiblioteca.Mapping
{
    public class EmprestimosMapping : IEntityTypeConfiguration<Emprestimo>
    {
        public void Configure(EntityTypeBuilder<Emprestimo> builder)
        {
            builder.HasKey(x => x.Numero);
            builder.Property(x => x.DataEmprestimo).HasColumnType("datetime").IsRequired();
            builder.Property(x => x.DataDevolucao).HasColumnType("datetime").IsRequired();
            builder.HasOne(x => x.Leitor)
                    .WithMany()
                    .HasForeignKey(x => x.CodigoLeitor);
            builder.ToTable("emprestimos");

        }
    }
}
