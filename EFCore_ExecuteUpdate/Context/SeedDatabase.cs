using EFCore_ExecuteUpdate.Context;
using EFCore_ExecuteUpdate.Models;

namespace EFCore_ExecuteUpdate;

public class SeedDatabase
{
    public static void PopulaDB(AppDbContext context)
    {
        context.Database.EnsureDeleted();//Exclui o banco
        context.Database.EnsureCreated();//Recria o banco

        Random random = new Random();

        context.Alunos.AddRange(Enumerable.Range(1, 500).Select(i =>
        {
            return new Aluno
            {
                Nome = $"{nameof(Aluno.Nome)}-{i}",
                Email = $"{nameof(Aluno.Email)}-{i}",
                Idade = random.Next(15, 20),
                Ativo = i % 2 == 0,
                DataMatricula = DateTime.UtcNow
            };
        }));
        context.SaveChanges();
    }
}
