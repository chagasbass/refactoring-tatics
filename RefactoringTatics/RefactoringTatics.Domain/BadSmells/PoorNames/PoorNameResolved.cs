using RefactoringTatics.Source.BadSmells.PrimitiveObsessions.ValueObjects;
using RefactoringTatics.Source.Domain.Interfaces;
using System;
using System.Collections.Generic;

namespace RefactoringTatics.Source.BadSmells.PoorNames
{
    public class PoorNameResolved
    {
        public string Nome { get; set; }
        public int Valor { get; set; }
        public DateTime DataCadastro { get; set; }
        public DateTime DataInicio { get; set; }

        private IOrderSource _orderSource;
        private IFactory _customerFactory;
        private IFactory _orderFactory;
        private IFactory _orderItemFactory;

        public List<int> GerarNumerosParesEmIntervaloDefinido(int valorInicial, int valorFinal)
        {
            var numerosPares = new List<int>();

            for (int numeroGerado = valorInicial; numeroGerado <= valorFinal; numeroGerado++)
            {
                if (numeroGerado % 2 == 0)
                {
                    numerosPares.Add(numeroGerado);
                }
            }

            return numerosPares;
        }

        /// <summary>
        /// (Abstraction Level) Erro de nível de abstração
        /// em nenhum momento o nome do método GetOrder expressa que será retornada
        /// uma ordem de arquivo.
        /// </summary>
        public void ProcessarOrdem()
        {
            var order = _orderSource.GetOrder();
        }

        #region Siga as convenções

        public void GenerateCustomer(int valor)
        {
            var customer = _customerFactory.Create(valor);
        }

        public void BuildOrder(int valor)
        {
            var order = _orderFactory.Make(valor);
        }

        /// <summary>
        /// Métodos SEMPRE com PascalCase
        /// </summary>
        public void MakeItem()
        {
            var orderItem = _orderItemFactory.NewItem();
        }


        public void Process()
        {
            var valor = 10;
            GenerateCustomer(valor);
            MakeItem();
            BuildOrder(valor);
        }

        #endregion

        #region Ambiguidade

        /*Fim dos nomes com ambiguidade
         *um único parametro para o método 
         *Depender sempre da abstração e nunca da implementação
         */ 
        
        public void ProcessarEnderecos()
        {
            var enderecoResidencial = new Endereco();
            var enderecoEmpresarial = new Endereco();
            var enderecoDeCompras = new Endereco();
            var enderecoDeCobrancas = new Endereco();

            var enderecos = new List<Endereco>()
            {
                enderecoResidencial,
                enderecoEmpresarial,
                enderecoDeCompras,
                enderecoDeCobrancas
            };

            SalvarEnderecos(enderecos);
        }

        public void SalvarEnderecos(IEnumerable<Endereco> enderecos)
        {
            //TODO:Faz algo com os endereços
        }

        #endregion
    }
}
