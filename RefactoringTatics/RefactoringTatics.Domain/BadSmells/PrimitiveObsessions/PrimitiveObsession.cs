namespace RefactoringTatics.Source.BadSmells.PrimitiveObsessions
{
    /// <summary>
    /// Demonstração de Primitive Obsession
    /// muitas propriedades como Tipo Primitivos
    /// </summary>
    public class PrimitiveObsession
    {
        public int Id { get; set; }
        public string Rua { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public int Numero { get; set; }
        public string Cep { get; set; }
        public string Complemento { get; set; }


        public PrimitiveObsession(string rua, string bairro,
                                  string cidade, int numero,
                                  string cep, string complemento)
        {
            Rua = rua;
            Bairro = bairro;
            Cidade = cidade;
            Numero = numero;
            Cep = cep;
            Complemento = complemento;
        }
    }
}
