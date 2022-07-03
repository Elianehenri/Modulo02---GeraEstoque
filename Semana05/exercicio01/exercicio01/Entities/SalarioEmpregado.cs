using System.Globalization;

namespace Exercicio01.Entities
{
    class SalarioEmpregado : Empregado
    {
        //propriedades
        public int CodigoFuncionario { get; set; }
        public double ValorSalario { get; set; }

        //construtores
        public SalarioEmpregado()
        {
        }

        public SalarioEmpregado(int codigoFuncionario, int id, string nome, double valorSalario) : base(id, nome)
        {
            CodigoFuncionario = codigoFuncionario;
            ValorSalario = valorSalario;
        }
        //metodo 
        public void CalcularFolhaPgto()
        {
            Console.WriteLine("Realizando calculo folha de pagamento!");
        }

    }
}
