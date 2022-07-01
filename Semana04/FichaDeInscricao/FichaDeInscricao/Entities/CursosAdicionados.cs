using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FichaDeInscricao.Entities
{
    class CursosAdicionados
    {
        private List<string> cursos;

        public CursosAdicionados()
        {
            cursos = new List<string>();
        }
        public void AdicionaCurso(string curso)
        {
            if (!cursos.Contains(curso))
                cursos.Add(curso);
        }

        public override string ToString()
        {
            if (cursos.Count > 0)
            {
                string cursoString = "";
                cursos.ForEach(c =>
                {
                    cursoString += $"{c},\n";
                });
                cursoString = cursoString.Substring(0, cursoString.Length - 2);
                return cursoString;
            }
            return "";
        }


    }
}
