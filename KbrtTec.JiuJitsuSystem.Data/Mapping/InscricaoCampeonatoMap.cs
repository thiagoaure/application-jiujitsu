using KbrTec.JiuJitsuSystem.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace KbrTec.JiuJitsuSystem.Data.Mapping;

public class InscricaoCampeonatoMap : IEntityTypeConfiguration<InscricaoCampeonato>
{
    public void Configure(EntityTypeBuilder<InscricaoCampeonato> builder)
    {
        builder.ToTable(nameof(InscricaoCampeonato));

        builder.HasKey(x => x.Id);

        builder.HasOne(ic => ic.Atleta)
            .WithMany()
            .HasForeignKey(ic => ic.AtletaId)
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasOne(ic => ic.Campeonato)
            .WithMany()
            .HasForeignKey(ic => ic.CampeonatoId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}
