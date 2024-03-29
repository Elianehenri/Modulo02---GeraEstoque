﻿

using FichaDeInscricao.Entities;

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
           
            
            
            FichaInscricao fichaInscricao = new FichaInscricao(nome, curso, escolaridade, Convert.ToDateTime(dataDeNascimento) ,  valorCurso, valorDesconto, valorMulta );

           

            CobrarCurso cobrarCurso = new CobrarCurso(fichaInscricao.ValorCurso,fichaInscricao.ValorMulta,fichaInscricao.ValorDesconto);
            cobrarCurso.CalcularResultado( );
            Console.Write("Idade: ");
            Console.WriteLine(fichaInscricao.Idade);
            FormatacaoText Formatacao = new FormatacaoText();
            cobrarCurso.Resultado.ToString("c");
        

            if (fichaInscricao.ValorDesconto == 0)
            {
                Console.Write(FormatacaoText.Formatacao(fichaInscricao.Nome, fichaInscricao.Curso, fichaInscricao.ValorCurso));
            }
            else if (fichaInscricao.ValorDesconto > 0 && fichaInscricao.Idade < 18)
            {
                Console.Write(FormatacaoText.Formatacao(fichaInscricao.Nome, fichaInscricao.Curso, fichaInscricao.ValorCurso, fichaInscricao.ValorDesconto, fichaInscricao.Idade));
            }
            else if (fichaInscricao.ValorDesconto > 0)
            {
                Console.Write(FormatacaoText.Formatacao(fichaInscricao.Nome, fichaInscricao.Curso, fichaInscricao.ValorCurso, fichaInscricao.ValorDesconto));
            }


           

            Console.WriteLine();
        }
    }
}
