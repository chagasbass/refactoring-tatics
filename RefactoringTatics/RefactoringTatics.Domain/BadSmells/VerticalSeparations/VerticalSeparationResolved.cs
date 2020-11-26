namespace RefactoringTatics.Source.BadSmells.VerticalSeparations
{
    /// <summary>
    /// Demonstração de Vertical Separation
    ///  refatorada organizado as declarações de variáveis e de métodos.
    /// </summary>
    public class VerticalSeparationResolved
    {
        public void RodarMetodoUm()
        {
            EfetuarRotinaCompartilhada();

            RodarMetodoDois();
            RodarMetodoDois();
            RodarMetodoDois();

            //variavel declarada proxima ao uso
            string meuValor = "meuValor";

            RodarMetodoTres(meuValor);
        }

        /// <summary>
        /// Foi declarado após o 1 uso
        /// </summary>
        private void EfetuarRotinaCompartilhada()
        {

        }

        public void RodarMetodoDois()
        {

        }

        public void RodarMetodoTres(string valor)
        {
            EfetuarRotinaCompartilhada();
        }
    }
}
