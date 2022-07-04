using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cartoes
{
    public class Cartao
    {
        //propriedades
        public string Bandeira { get; set; }
        public double Saldo { get; set; }
        public double ValorTaxa { get; set; }

        //construtores
        public Cartao()
        {
        }

        public Cartao(string bandeira, double saldo, double valorTaxa)
        {
            Bandeira = bandeira;
            Saldo = saldo;
            ValorTaxa = valorTaxa;
        }

        //metodo
        public virtual double VerificarValorTaxaCartao()
        {
            return Saldo * ValorTaxa;
        }
    }
}
