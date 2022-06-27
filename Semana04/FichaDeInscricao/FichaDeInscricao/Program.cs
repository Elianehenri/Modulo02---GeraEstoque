using System;

namespace FichaDeInscricao
{
   class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ficha de Inscriçao");
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Curso: ");
            string curso = Console.ReadLine();
            Console.Write("Escolaridade: ");
            string escolaridade = Console.ReadLine();
            Console.Write("Digite data de nascimento: ");
            DateTime dataDeNascimento = Convert.ToDateTime(Console.ReadLine());

            Console.Write("Valor do Curso: ");
           double valorCurso = int.Parse(Console.ReadLine());
            Console.Write("Valor do Desconto: ");
            double valorDesconto = int.Parse(Console.ReadLine());
            Console.Write("Valor da Multa: ");
            double valorMulta = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.ReadLine();

        }
    }
}
