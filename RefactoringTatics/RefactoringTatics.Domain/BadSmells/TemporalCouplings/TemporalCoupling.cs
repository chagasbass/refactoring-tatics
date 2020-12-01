namespace RefactoringTatics.Source.BadSmells.TemporalCouplings
{
    /// <summary>
    /// Acoplamento temporal 
    /// fluxos que precisam ser executados na ordem correta
    /// </summary>
    public class TemporalCoupling
    {
        public TemporalCoupling()
        {
            executarFluxoUm();
            executarFluxoDois();
            executarFluxoTres();
            executarFluxoQuatro();
        }
    }
}
