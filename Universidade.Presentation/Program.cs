using Microsoft.EntityFrameworkCore;
using Universidade.Domain;
using Universidade.Infra;

namespace Universidade.Presentation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var aluno1 = new Aluno
            {
                Id = 1,
                CPF = "123.456.789-00",
                Matricula = "123456",
                Nome = "Aluno1",
                Email = "aluno1@gmail.com",
                Telefone = "987654321",
                DataNascimento = DateTime.Parse("Dec 18, 2005")
            };

            var aluno2 = new Aluno
            {
                Id = 2,
                CPF = "123.456.789-99",
                Matricula = "234567",
                Nome = "Aluno2",
                Email = "aluno2@gmail.com",
                Telefone = "912345678",
                DataNascimento = DateTime.Parse("Dec 18, 2005")
            };

            var professor1 = new Professor
            {
                Id = 3,
                CPF = "123.456.789-00",
                Matricula = "123456",
                Nome = "Professor1",
                Email = "professor1@gmail.com",
                Telefone = "987654321",
                DataNascimento = DateTime.Parse("Dec 18, 1992")
            };

            var professor2 = new Professor
            {
                Id = 4,
                CPF = "123.456.789-99",
                Matricula = "234567",
                Nome = "Professor2",
                Email = "professor2@gmail.com",
                Telefone = "912345678",
                DataNascimento = DateTime.Parse("Jan 01, 1987")
            };

            using (var context = new AppDbContext())
            {
                context.Alunos.Add(aluno1);
                context.Alunos.Add(aluno2);
                context.Professores.Add(professor1);
                context.Professores.Add(professor2);

                // Salvar as alterações no banco
                context.SaveChanges();
                Console.WriteLine("Registros inseridos com sucesso!");
            }
        }
    }
}
