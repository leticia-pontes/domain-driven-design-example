using Universidade.Domain;
using Microsoft.EntityFrameworkCore;

namespace Universidade.Infra;

public class AppDbContext : DbContext
{
    public DbSet<Aluno> Alunos { get; set; }

    protected override void OnConfiguring(DbContextOptions)
    {
        optionsBuilder.UseSqlServer();
    }
}