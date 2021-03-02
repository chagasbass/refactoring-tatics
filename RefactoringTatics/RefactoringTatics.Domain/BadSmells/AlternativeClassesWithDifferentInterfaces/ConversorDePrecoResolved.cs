namespace RefactoringTatics.Source.BadSmells.AlternativeClassesWithDifferentInterfaces
{
    public class ConversorDePrecoResolved
    {
        public double ConverterValoresParaMoedas(double valor, TipoMoeda tipoMoeda)
        {
            var conversor = new Conversor(tipoMoeda);

            return  conversor.Converter(valor);
        }
    }
}
