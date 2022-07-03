using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio01.Entities
{
    //propriedades
    class FuncionarioHorista : Empregado
    {
        public string Cnpj { get; set; }
        public double Taxa { get; set; }

        //cnstrutores
        public FuncionarioHorista()
        {
        }

        public FuncionarioHorista(int id, string cnpj, string nome, double taxa) : base(id, nome)
        {
            Cnpj = cnpj;
            Taxa = taxa;
        }

        //metodos
        public void CalcularTaxas()
        {

            Console.WriteLine("Realizando calculo das taxas!");
        }

        public void EmitirNota()
        {
            Console.WriteLine("Emitindo a nota de serviço!");
        }
    }



}
