namespace RefactoringTatics.Source.BadSmells.VerticalSeparations
{
    /// <summary>
    /// Demonstração de Vertical Separation
    /// Variáveis e funções devem ser declaradas onde elas serão usadas.
    /// </summary>
    public class VerticalSeparation
    {
        public void RodarMetodoUm()
        {
            string meuValor = "meuValor";
            EfetuarRotinaCompartilhada();
            RodarMetodoDois();
            RodarMetodoDois();
            RodarMetodoDois();
            RodarMetodoTres(meuValor);
        }

        public void RodarMetodoDois()
        {

        }

        public void RodarMetodoTres(string valor)
        {
            EfetuarRotinaCompartilhada();
        }

        private void EfetuarRotinaCompartilhada()
        {

        }
    }
}
