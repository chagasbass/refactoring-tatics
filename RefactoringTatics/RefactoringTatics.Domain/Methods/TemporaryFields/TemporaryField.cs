namespace RefactoringTatics.Source.Methods.TemporaryFields
{
    public class TemporaryField
    {
        public object ConcatenarNome(string nomeCliente)
        {
            var nomeSemConcatenacao = nomeCliente.Split('-');
            var primeiroNome = nomeSemConcatenacao[0];
            var sobrenome = nomeSemConcatenacao[1];

            var nomeConcatenado = new
            {
                Nome = primeiroNome,
                Sobrenome = sobrenome
            };

            return nomeConcatenado;
        }

        public int SomarNumeros(int a,int b)
        {
            var total = a + b;

            return total;
        }
    }
}
