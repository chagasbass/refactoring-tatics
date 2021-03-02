using System;

namespace RefactoringTatics.Source.BadSmells.ObjectOrientedAbusers
{
    public abstract class ClassePai
    {
        public virtual void  RotinaUm()
        {
            Console.WriteLine("Faz algo interessante.");
        }

        public virtual void RotinaDois()
        {
            Console.WriteLine("Faz algo quase interessante.");
        }

        public virtual void RotinaTres()
        {
            Console.WriteLine("Faz algo  bem interessante.");
        }
    }

    public class ClasseDerivada : ClassePai
    {
        public override void RotinaUm()
        {
            Console.WriteLine("Faz algo MUITO MAIS interessante.");
        }

        public override void RotinaDois()
        {
            Console.WriteLine("Faz algo MUITO MAIS interessante TAMBÉM.");
        }
    }
}
