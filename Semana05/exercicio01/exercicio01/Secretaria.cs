using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio01
{
    class Secretaria : SalarioEmpregado
    {
        //propriedades
        public int QtdAnosEmpresa { get; set; }

        //construtores
        public Secretaria()
        {
        }

        public Secretaria(int codigoFuncionario, int id, string nome, double valorSalario, int qtdAnosEmpresa) : base(codigoFuncionario, id, nome, valorSalario)
        {
            QtdAnosEmpresa = qtdAnosEmpresa;
        }
        //metodos
        public void AtenderCliente()
        {
            Console.WriteLine("Cliente sendo atendido!");
        }

        public void RealizarLigacoes()
        {
            Console.WriteLine("Realizando Ligaçoes");
        }

    }
}
