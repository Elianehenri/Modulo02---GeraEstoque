using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FichaDeInscricao.Entities
{
    public class FormatacaoText
    {


        //exercicio 04
        #region classe static para efetuar sobrecarga formataçao de texto 

        public static string Formatacao(string nome, string curso, double valorCurso)
        {
            return $"Nome:{nome}  Curso:{curso}   Valor R$:{valorCurso} ";

        }

        public static string Formatacao(string nome, string curso, double valorCurso, double valorDesconto)
        {
            return $"Nome:{nome}, Curso:{curso}, Valor R$:{valorCurso},  Desconto R$:{valorDesconto}";

        }

        public static string Formatacao(string nome, string curso, double valorCurso, double valorDesconto, int idade)
        {
            return $"Nome:{nome}  Idade:{idade} Anos Curso:{curso}  Valor R$:{valorCurso} Desconto R$:{valorDesconto}";


        }
        #endregion
    }
}
