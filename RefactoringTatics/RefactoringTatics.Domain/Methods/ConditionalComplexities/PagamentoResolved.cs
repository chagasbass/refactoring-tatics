using System;

namespace RefactoringTatics.Source.Methods.ConditionalComplexities
{
    public class PagamentoResolved
    {
        public DateTime DataCompra { get; set; }
        public DateTime DataPagamento { get; set; }
        public double Preco { get; set; }
        public double Parcela { get; set; }

        private double PercentualDeJuros { get; set; } = 15.0;
        private double PercentualDeDescontos { get; set; } = 5.0;
        private double ValorPorcentagemTotal { get; set; } = 100.0;

        public PagamentoResolved(DateTime dataCompra, double preco, double parcela)
        {
            DataCompra = dataCompra;
            Preco = preco;
            Parcela = parcela;
        }

        public void EFetuarPagamento(DateTime dataPagamento)
        {
            if (dataPagamento.Day > DataCompra.Day)
                EfetuarPagamentoAposVencimento(dataPagamento);
            if (dataPagamento.Day == DataCompra.Day)
                EfetuarPagamentoNoDiaDoVencimento(dataPagamento);
            else
                EfetuarPagamentoAntesDoVencimento(dataPagamento);
        }

        public void EfetuarPagamentoAposVencimento(DateTime dataPagamento)
        {
            var percentual = PercentualDeJuros / ValorPorcentagemTotal;
            Preco = Preco + (percentual * Preco);
        }
        public void EfetuarPagamentoNoDiaDoVencimento(DateTime dataPagamento)
        {
            var percentual = PercentualDeJuros - 4 / ValorPorcentagemTotal;
            Preco = Preco + (percentual * Preco);
        }
        public void EfetuarPagamentoAntesDoVencimento(DateTime dataPagamento)
        {
            var percentual = PercentualDeDescontos / ValorPorcentagemTotal;
            Preco = Preco - (percentual * Preco);
        }
    }
}
