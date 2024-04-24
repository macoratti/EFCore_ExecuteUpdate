using EFCore_ExecuteUpdate.Models;
using Microsoft.EntityFrameworkCore;

namespace EFCore_ExecuteUpdate.Context;

public class AppDbContext : DbContext
{
    public DbSet<Aluno> Alunos { get; set; }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(
         "Data Source=Desktop-dk57unp\\SQLEXPRESS;Initial Catalog=AlunosDB;Integrated Security=True;TrustServerCertificate=True;")
         .LogTo(Console.WriteLine, Microsoft.Extensions.Logging.LogLevel.Information);
    }
}

