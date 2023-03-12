using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Exercicio 1 e 4
namespace ListaAluno
{
    internal class Aluno
    {

        public string ra;
        public string nome;
        public decimal notaProva;
        public decimal notaTrabalho;
        public decimal notaProva2;
        public decimal notaTrabalho2;
        decimal notaFinal {get; set;}
        decimal notaTotal { get; set;}


        public void CalcularMedia()
        {
            notaTotal = (notaProva + notaTrabalho + notaProva2 + notaTrabalho2);
            notaFinal = notaTotal / 2;
        }
        public bool CalcularNotaFinal()
        {

            decimal valorPassar = 14;
            if ((notaTotal) < valorPassar)

            {
                Console.WriteLine("Aluno Reprovado!");
                Console.WriteLine("Nota necessaria para prova final: " + (12 - (notaFinal)));
                return true;
            }
            else
            {
                Console.WriteLine("Aluno Aprovado!");
                return false;
            }

        }
        public void ImprimirNotaFinal()
        {
            Console.WriteLine($"Nota Bimestre: {(notaTotal).ToString("N2")}");
        }
        public void ReceberDados()
        {
            Console.Write("Digite o RA do aluno: ");
            ra = Console.ReadLine();
            Console.Write("Digite o Nome do aluno: ");
            nome = Console.ReadLine();
            Console.Write("Digite o valor da Prova: ");
            notaProva = Decimal.Parse(Console.ReadLine());
            Console.Write("Digite o valor da Prova 2: ");
            notaProva2 = Decimal.Parse(Console.ReadLine());
            Console.Write("Digite o valor do Trabalho: ");
            notaTrabalho = Decimal.Parse(Console.ReadLine());
            Console.Write("Digite o valor do Trabalho 2: ");
            notaTrabalho2 = Decimal.Parse(Console.ReadLine());

        }
    }
}