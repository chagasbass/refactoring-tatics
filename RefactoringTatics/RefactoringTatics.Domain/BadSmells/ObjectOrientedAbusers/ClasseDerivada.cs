using System;

namespace RefactoringTatics.Source.BadSmells.ObjectOrientedAbusers
{
    public class ClasseDerivada : ClassePai
    {
        public override void RotinaUm()
        {
            Console.WriteLine("Faz algo MUITO MAIS interessante.");
        }
    }
}
