namespace RefactoringTatics.Source.Methods.TemporaryFields
{
    public class TemporaryFieldResolved
    {
        public NomeOrganizado SepararNome(string nomeCliente)
        {
            NomeOrganizado nomeOrganizado = null;

            if (!string.IsNullOrEmpty(nomeCliente))
            {
                var nomeSemConcatenacao = nomeCliente.Split('-');

                nomeOrganizado = new NomeOrganizado(nomeSemConcatenacao[0], nomeSemConcatenacao[1]);
            }

            return nomeOrganizado;
        }

        public int SomarNumeros(int numeroUm, int numeroDois)
        {
            return numeroUm + numeroDois;
        }
    }

    public class NomeOrganizado
    {
        public NomeOrganizado(string primeiroNome, string sobrenome)
        {
            PrimeiroNome = primeiroNome;
            Sobrenome = sobrenome;
        }

        public string PrimeiroNome { get; set; }
        public string Sobrenome { get; set; }
    }
}
