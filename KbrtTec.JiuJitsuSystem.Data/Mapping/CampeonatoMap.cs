using KbrTec.JiuJitsuSystem.Domain;
using KbrTec.JiuJitsuSystem.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace KbrTec.JiuJitsuSystem.Data.Mapping;

public class CampeonatoMap : IEntityTypeConfiguration<Campeonato>
{
    public void Configure(EntityTypeBuilder<Campeonato> builder)
    {
        builder.ToTable(nameof(Campeonato));

        builder.HasKey(x => x.Id);

        builder.Property(x => x.Titulo)
            .HasConversion(x => x.ToString(), x => x)
            .IsRequired()
            .HasColumnType("varchar(100)");

        builder.Property(x => x.Imagem)
            .HasConversion(x => x.ToString(), x => x)
            .IsRequired()
            .HasColumnType("varchar(50)");

        builder.OwnsOne(x => x.Endereco, endereco =>
        {
            endereco.Property(e => e.Cidade)
                .HasColumnName("Cidade")
                .HasConversion(x => x.ToString(), x => x)
                .IsRequired()
                .HasColumnType("varchar(50)");

            endereco.Property(e => e.Estado)
                .HasColumnName("Estado")
                .HasConversion(x => x.ToString(), x => x)
                .IsRequired()
                .HasColumnType("varchar(50)");

        });

        builder.Property(x => x.DataRealizacao)
            .IsRequired()
            .HasColumnType("date");

        builder.Property(x => x.Ginasio)
            .HasConversion(x => x.ToString(), x => x)
            .IsRequired()
            .HasColumnType("varchar(50)");

        builder.Property(x => x.InformacoesGerais)
            .HasConversion(x => x.ToString(), x => x)
            .IsRequired()
            .HasColumnType("varchar(100)");

        builder.Property(x => x.EntradaPublico)
            .HasColumnType("bit");

        builder.Property(x => x.TipoCamepeonato)
            .IsRequired()
            .HasConversion(
                v => (int)v,
                v => (ETipoCampeonato)v
            );

        builder.Property(x => x.FaseCampeonato)
            .IsRequired()
            .HasConversion(
                v => (int)v,
                v => (EFaseCampeonato)v
            );

        builder.Property(x => x.StatusCampeonato)
            .IsRequired()
            .HasConversion(
                v => (int)v,
                v => (EStatusCampeonato)v
            );

    }
}
