using KbrTec.JiuJitsuSystem.Domain;
using KbrTec.JiuJitsuSystem.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace KbrTec.JiuJitsuSystem.Data.Mapping;

public class UsuarioMap : IEntityTypeConfiguration<Usuario>
{
    public void Configure(EntityTypeBuilder<Usuario> builder)
    {
        builder.ToTable(nameof(Usuario));

        builder.HasKey(x => x.Id);

        builder.Property(x => x.Nome)
            .HasConversion(x => x.ToString(), x => x)
            .IsRequired()
            .HasColumnType("varchar(100)");

        builder.Property(x => x.Email)
            .HasConversion(x => x.ToString(), x => x)
            .IsRequired()
            .HasColumnType("varchar(50)");

        builder.Property(x => x.Senha)
            .HasConversion(x => x.ToString(), x => x)
            .IsRequired()
            .HasColumnType("varchar(100)");

        builder.Property(x => x.TipoUsuario)
            .IsRequired()
            .HasConversion(
                v => (int)v,
                v => (ETipoUsuario)v
            );
    }

}
