﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FichaDeInscricao
{
  class FichaInscricao
    {   //exercicio 01
        #region propriedades
        public string Nome { get; set; }
        public int Idade { get; }
        public string Curso { get; set; }
        public string Escolaridade { get; set; }
        public DateTime DataDeNascimento { get; set; }//
        public decimal ValorCurso { get; set; }
        public decimal ValorDesconto { get; set; }
        public decimal ValorMulta { get; set; }

        #endregion
    }
}