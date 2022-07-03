using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio01
{
    class Empregado
    {
        //propriedades
        public int Id { get; set; }
        public string Nome { get; set; }

        //construtor
        public Empregado()
        {
        }

        public Empregado(int id, string nome)
        {
            Id = id;
            Nome = nome;
        }

        //metodo
        public void Trabalhar(string tipo)
        {
            Console.WriteLine(tipo);
        }
        public void IrEmbora()
        {
            Console.WriteLine("Saindo da empresa!");
        }
        public void TirarFolga()
        {
            Console.WriteLine( "Tirando Folga!");
        }
    }
}
