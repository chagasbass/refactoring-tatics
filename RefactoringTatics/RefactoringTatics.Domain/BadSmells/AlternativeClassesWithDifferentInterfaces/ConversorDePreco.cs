namespace RefactoringTatics.Source.BadSmells.AlternativeClassesWithDifferentInterfaces
{
    public class ConversorDePreco
    {
        public double ConverterValoresParaMoedas(double valor, TipoMoeda tipoMoeda)
        {
            switch (tipoMoeda)
            {
                case TipoMoeda.DOLAR_AMERICANO:
                    return valor * 0.5;
                case TipoMoeda.EURO:
                    return valor * 0.8;
                case TipoMoeda.DOLAR_CANADENSE:
                    return valor * 0.5;
                default:
                    return 0;
            }
        }
    }
}
