
// Exercicio 1 e 4
using ListaAluno;
Console.WriteLine("DIgite a quantidade de alunos");
int quantidadeAlunos = int.Parse(Console.ReadLine());

List<Aluno> listaAlunos = new List<Aluno>();
for (int i = 0; i < quantidadeAlunos; i++)
{
    Console.WriteLine("\nDigite numero de alunos{0}", i + 1);

    Aluno aluno = new Aluno();
    aluno.ReceberDados();
    aluno.CalcularMedia();
    listaAlunos.Add(aluno);

}

Console.WriteLine("\n Notas Finais");
foreach (Aluno aluno in listaAlunos)
{
    aluno.CalcularNotaFinal();
    aluno.ImprimirNotaFinal();
}

Console.ReadLine();
