namespace Universidade.Domain;

public class Aluno
{
    public int Id { get; set; }
    public string CPF { get; set; }
    public string Matricula { get; set; }
    public string Nome { get; set; }
    public string? Email { get; set; }
    public string? Telefone { get; set; }
    public DateTime DataNascimento { get; set; }
}