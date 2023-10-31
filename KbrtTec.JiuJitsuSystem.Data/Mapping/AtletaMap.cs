using KbrTec.JiuJitsuSystem.Domain;
using KbrTec.JiuJitsuSystem.Domain.Entities;
using KbrTec.JiuJitsuSystem.Domain.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace KbrTec.JiuJitsuSystem.Data.Mapping;

public class AtletaMap : IEntityTypeConfiguration<Atleta>
{
    public void Configure(EntityTypeBuilder<Atleta> builder)
    {
        builder.ToTable(nameof(Atleta));

        builder.HasKey(x => x.Id);

        builder.Property(x => x.Nome)
            .HasConversion(x => x.ToString(), x => x)
            .IsRequired()
            .HasColumnType("varchar(100)");

        builder.Property(x => x.DataNascimento)
            .IsRequired()
            .HasColumnType("date");

        builder.Property(x => x.Cpf)
            .HasConversion(x => x.ToString(), x => x)
            .IsRequired()
            .HasColumnType("varchar(11)");

        builder.Property(x => x.DataIncricao)
            .IsRequired()
            .HasColumnType("date");

        builder.Property(x => x.Sexo)
            .HasConversion(
                v => (int)v,
                v => (ESexo)v
            );

        builder.Property(x => x.Email)
            .HasConversion(x => x.ToString(), x => x)
            .IsRequired()
            .HasColumnType("varchar(50)");

        builder.Property(x => x.Senha)
            .HasConversion(x => x.ToString(), x => x)
            .IsRequired()
            .HasColumnType("varchar(50)");

        builder.Property(x => x.Equipe)
            .HasConversion(x => x.ToString(), x => x)
            .IsRequired()
            .HasColumnType("varchar(50)");

        builder.Property(x => x.TipoFaixa)
            .IsRequired()
            .HasConversion(
                v => (int)v,
                v => (ETipoFaixa)v
            );

        builder.Property(x => x.TipoPeso)
            .IsRequired()
            .HasConversion(
                v => (int)v,
                v => (ETipoPeso)v
            );

    }
}
