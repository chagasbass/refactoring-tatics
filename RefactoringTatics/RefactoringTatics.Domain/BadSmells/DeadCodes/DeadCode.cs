using System;
using System.Collections.Generic;

namespace RefactoringTatics.Source.BadSmells.DeadCodes
{
    public class DeadCode
    {
        public string EfetuarRotinaDeCriacaoDeData()
        {
            int dia;
            int mes;
            int ano;
            

            DateTime dataAtual = DateTime.Now;

            return dataAtual.ToString();
        }
    }
}
