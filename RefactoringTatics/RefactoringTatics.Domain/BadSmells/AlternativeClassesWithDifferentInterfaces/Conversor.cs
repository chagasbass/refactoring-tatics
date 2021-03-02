namespace RefactoringTatics.Source.BadSmells.AlternativeClassesWithDifferentInterfaces
{
    public class Conversor
    {
        private readonly TipoMoeda Moeda; 

        public Conversor(TipoMoeda moeda)
        {
            Moeda = moeda;
        }

        public double Converter(double valor)
        {
            switch (Moeda)
            {
                case "DOLAR_AMERICANO":
                    return valor * 0.5;
                case "EURO":
                    return valor * 0.8;
                case "DOLAR_CANADENSE":
                    return valor * 0.5;
                default:
                    return 0;
                    break;
            }
        }
    }

    public enum TipoMoeda
    {
        DOLAR_AMERICANO,
        DOLAR_CANADENSE,
        EURO
    }
}
