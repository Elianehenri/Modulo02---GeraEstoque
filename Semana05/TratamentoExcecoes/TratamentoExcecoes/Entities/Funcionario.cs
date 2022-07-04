using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TratamentoExcecoes.Entities
{
    class Funcionario
    {
        //propriedade
        public string Id { get; set; }
        public string Nome { get; set; }
        //construtor
        public Funcionario()
        {
        }

        public Funcionario(string id, string name)
        {
            Id = id;
            Nome = name;
        }

 

    }
    [Serializable]
    public class NomeFuncionarioInvalidoException : Exception
    {
        public NomeFuncionarioInvalidoException()
        {

        }
        public NomeFuncionarioInvalidoException(string nome) : base(string.Format($"Nome Funcionario Invalido: {nome}"))
        {

        }
    }

    public class IdFuncionarioInvalidoException : Exception
    {
        public IdFuncionarioInvalidoException()
        {

        }

        public IdFuncionarioInvalidoException(string id) : base(string.Format($"ID do funcionario é invalido: {id}"))
        {

        }
    }
}
