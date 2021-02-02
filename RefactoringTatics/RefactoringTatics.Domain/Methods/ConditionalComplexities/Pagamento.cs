using System;

namespace RefactoringTatics.Source.Methods.ConditionalComplexities
{
    public class Pagamento
    {
        public DateTime DataCompra { get; set; }
        public DateTime DataPagamento { get; set; }
        public double Preco { get; set; }
        public double Parcela { get; set; }
        public int ContadorDeJuros { get; set; }

        private  double PercentualDeJuros { get; set; } = 15.0;
        private double PercentualDeDescontos { get; set; } = 5.0;

        public Pagamento(DateTime dataCompra,double preco, double parcela)
        {
            DataCompra = dataCompra;
            Preco = preco;
            Parcela = parcela;
        }

        public void EFetuarPagamento(DateTime dataPagamento)
        {
            var valorPorcentagemTotal = 100.0;

            if(dataPagamento.Day > DataCompra.Day)
            {
                var percentual = PercentualDeJuros / valorPorcentagemTotal;
                Preco = Preco + (percentual * Preco);
            }
            if (dataPagamento.Day == DataCompra.Day)
            {
                var percentual = PercentualDeJuros -4 / valorPorcentagemTotal;
                Preco = Preco + (percentual * Preco);
            }
            else
            {
                var percentual = PercentualDeDescontos / valorPorcentagemTotal;
                Preco = Preco - (percentual * Preco);
            }
        }
    }
}
