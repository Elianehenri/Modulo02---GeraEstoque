using System.Text.RegularExpressions;
using System;
using TratamentoExcecoes.Entities;

namespace TratamentoExcecoes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            Console.WriteLine("Exercicios 05 e 06 da Semana 05!");
            Console.WriteLine("*********************************");

            Funcionario funcionario = new Funcionario("12345", "Eliane");
            Funcionario funcionario1 = new Funcionario(" ", " ");


            Console.Write("Digite o nome do funcionario:");
            funcionario1.Nome = Console.ReadLine();
            Console.Write("Digite o ID do funcionario:");
            funcionario1.Id = Console.ReadLine();

            try
            {
                ValidarFuncionario(funcionario);
                ValidarNomeFuncionario(funcionario1);
                ValidarIdFuncionario(funcionario1);


                Console.WriteLine($"ID: {funcionario.Id}, Nome: {funcionario.Nome} ");
                Console.WriteLine($"ID: {funcionario1.Id}, Nome: {funcionario1.Nome} ");
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
        }

        private static void ValidarFuncionario(Funcionario funcionario)
        {
            if (funcionario == null)
            {
                throw new NullReferenceException(" O Funcionario é Null!");
            }
        }

        private static void ValidarNomeFuncionario(Funcionario funcionario1)
        {
            Regex regexNome = new Regex("^[async-zA-Z]+$");
            if (!regexNome.IsMatch(funcionario1.Nome))

            {
                throw new NomeFuncionarioInvalidoException(funcionario1.Nome);
            }
        }
        private static void ValidarIdFuncionario(Funcionario funcionario1)
        {
            Regex regexId = new Regex("^[0-9]+$");
            if (!regexId.IsMatch(funcionario1.Id))
            {
                throw new IdFuncionarioInvalidoException(funcionario1.Id);
            }
        }
    }
}