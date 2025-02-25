using Universidade.Domain;
using Microsoft.EntityFrameworkCore;

namespace Universidade.Infra;

public class AppDbContext : DbContext
{
    public DbSet<Aluno> Alunos { get; set; }
    public DbSet<Professor> Professores { get; set; }

    public AppDbContext() : base() { }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            optionsBuilder.UseMySql("Server=localhost;Database=Universidade;User=root;Password=Kh@leesi154;",
                new MySqlServerVersion(new Version(8, 0, 28)));
        }
    }
}