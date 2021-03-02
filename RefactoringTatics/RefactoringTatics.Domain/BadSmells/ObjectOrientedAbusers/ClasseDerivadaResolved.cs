using System;

namespace RefactoringTatics.Source.BadSmells.ObjectOrientedAbusers
{
    public class ClasseDerivadaResolved : ClassePaiResolved
    {
        public void EfetuarRotinaUmDaClasseDerivada()
        {
            Console.WriteLine("Faz algo MUITO MAIS interessante.");
        }

        public void EfetuarRotinaDoisDaClasseDerivada()
        {
            Console.WriteLine("Faz algo MUITO MAIS interessante TAMBÉM.");
        }
    }
}
