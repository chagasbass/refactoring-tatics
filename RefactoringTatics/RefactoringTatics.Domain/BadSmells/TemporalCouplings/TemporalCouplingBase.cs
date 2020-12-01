namespace RefactoringTatics.Source.BadSmells.TemporalCouplings
{
    public abstract class TemporalCouplingBase
    {
        public void EfetuarFluxos()
        {
            ExecutarFluxoUm();
            ExecutarFluxoDois();
            ExecutarFluxoTres();
            ExecutarFluxoQuatro();
        }

        protected abstract void ExecutarFluxoUm();
        protected abstract void ExecutarFluxoDois();
        protected abstract void ExecutarFluxoTres();
        protected abstract void ExecutarFluxoQuatro();
    }
}
