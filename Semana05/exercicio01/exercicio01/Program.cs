using System;
using System.Globalization;
using System.Collections.Generic;

namespace Exercicio01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercicios Semana 05 Professor Jaime - Herança!");
            Console.WriteLine("***********************************************");
            Console.WriteLine();

            Empregado empregado = new Empregado(01, "Eliane");
            Console.WriteLine($"ID: {empregado.Id},  Nome: {empregado.Nome}");
            empregado.Trabalhar("Trabalhando!");
            empregado.IrEmbora();
            empregado.TirarFolga();
            Console.WriteLine();
            Console.WriteLine("******************************");

            SalarioEmpregado salario = new SalarioEmpregado(1020, 2, "Ana Paula", 1500.00);
            Console.WriteLine($"Cod.Funcionario: {salario.CodigoFuncionario}, ID: {salario.Id} , Nome: {salario.Nome}, Salario R$: {salario.ValorSalario.ToString("F2", CultureInfo.InvariantCulture)}");
            salario.Trabalhar("Trabalhando!");
            salario.IrEmbora();
            salario.TirarFolga();
            salario.CalcularFolhaPgto();
            Console.WriteLine();
            Console.WriteLine("******************************");

            Secretaria secretaria = new Secretaria(1030, 03, " Paulo", 1450.00, 10);
            Console.WriteLine($"Cod.Funcionario: {secretaria.CodigoFuncionario}, ID: {secretaria.Id}, Nome: {secretaria.Nome}, Salario: {secretaria.ValorSalario.ToString("F2", CultureInfo.InvariantCulture)}, Tempo na empresa: {secretaria.QtdAnosEmpresa} anos.");
            secretaria.Trabalhar("Trabalhando!");
            secretaria.IrEmbora();
            secretaria.TirarFolga();
            secretaria.CalcularFolhaPgto();
            Console.WriteLine();
            Console.WriteLine("******************************");

            FuncionarioHorista funcionarioHorista = new FuncionarioHorista(04, "10.515.652.0001-10", "EadTech" , 1.5);
            Console.WriteLine($"ID: {funcionarioHorista.Id}, CNPJ: {funcionarioHorista.Cnpj}, Nome: {funcionarioHorista.Nome}, Taxa: {funcionarioHorista.Taxa}%");
            funcionarioHorista.Trabalhar("Trabalhando!");
            funcionarioHorista.IrEmbora();
            funcionarioHorista.TirarFolga();
            funcionarioHorista.CalcularTaxas();
            funcionarioHorista.EmitirNota();


            Console.ReadLine();
        }

    }
}