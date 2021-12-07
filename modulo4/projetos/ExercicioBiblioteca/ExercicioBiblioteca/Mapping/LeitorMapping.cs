using ExercicioBiblioteca.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExercicioBiblioteca.Mapping
{
    public class LeitorMapping : IEntityTypeConfiguration<Leitor>
    {
        public void Configure(EntityTypeBuilder<Leitor> builder)
        {
            builder.HasKey(x => x.Codigo);
            builder.Property(x => x.Nome).HasColumnType("VARCHAR(60)").IsRequired();
            builder.Property(X => X.CPF).IsRequired();
            builder.Property(X => X.Email).HasColumnType("VARCHAR(255)").IsRequired(false);
            builder.Property(x => x.Telefone).HasColumnType("VARCHAR(15)").IsRequired();
            builder.ToTable("leitores");
        }
    }
}
