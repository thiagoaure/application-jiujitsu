using KbrTec.JiuJitsuSystem.Data.Mapping;
using KbrTec.JiuJitsuSystem.Domain.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace KbrTec.JiuJitsuSystem.Data.Context;

public class AppDbContext : DbContext
{
    public DbSet<Atleta> Atletas { get; set; }
    public DbSet<Campeonato> Campeonatos { get; set; }
    public DbSet<Usuario> Usuarios { get; set; }
    public DbSet<InscricaoCampeonato> InscricoesCampeonatos { get; set; }

    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Atleta>(new AtletaMap().Configure);
        modelBuilder.Entity<Campeonato>(new CampeonatoMap().Configure);
        modelBuilder.Entity<Usuario>(new UsuarioMap().Configure);
        modelBuilder.Entity<InscricaoCampeonato>(new InscricaoCampeonatoMap().Configure);
    }
}
