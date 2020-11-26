using RefactoringTatics.Source.BadSmells.PrimitiveObsessions.ValueObjects;
using RefactoringTatics.Source.Domain.Interfaces;
using System;
using System.Collections.Generic;

namespace RefactoringTatics.Source.BadSmells.PoorNames
{
    /// <summary>
    /// Demonstração de Poor Names
    /// Nomes de variáveis,métodos sem expressão
    /// </summary>
    public class PoorName
    {
        /// <summary>
        /// Notação húngara (Deprecated)
        /// </summary>
        public string strNome { get; set; }
        public int x { get; set; }
        public DateTime datacadastro { get; set; } //declaração de padrão inválido
        public DateTime dtInicio { get; set; } //EVITE PREFIXOS


        private  IOrderSource oSource;
        private IFactory _customerFactory;
        private IFactory _orderBuilder;
        private IFactory _orderItemMaker;

        /// <summary>
        /// Não demonstra a intenção do método
        /// </summary>
        /// <param name="i">nomes sem significado</param>
        /// <param name="f">nomes sem significado</param>
        /// <returns></returns>
        public List<int> Gerar(int i, int f)
        {
            var l = new List<int>();

            for (int y = i; x <= f; x++)
            {
                if(y % 2 == 0)
                {
                    l.Add(y);
                }
            }

            return l;
        }


        /// <summary>
        /// (Abstraction Level) Erro de nível de abstração
        /// em nenhum momento o nome do método GetOrder expressa que será retornada
        /// uma ordem de arquivo.
        /// </summary>
        public void ProcessarOrdem()
        {
            var orderFromFile = oSource.GetOrder();
        }

        #region Siga as convenções

        /*
         * Cada método que implementa a fábrica fictícia 
         * chama de forma diferente, mesmo implementando a mesma interface 
         * que o propósito é ser uma fábrica são nomeados de modo diferente.
         * 
         */

        public void GenerateCustomer(int valor)
        {
            var customer = _customerFactory.Create(valor);
        }

        public void BuildOrder(int valor)
        {
            var order = _orderBuilder.Make(valor);
        }

        /// <summary>
        /// Métodos NUNCA em camelCase
        /// </summary>
        public void makeItem()
        {
            var orderItem = _orderItemMaker.NewItem();
        }

        public void Process()
        {
            var valor = 10;
            GenerateCustomer(valor);
            makeItem();
            BuildOrder(valor);
        }

        #endregion

        #region Ambiguidade

        /// <summary>
        /// Ambiguidade de informações
        /// métodos com muitos parâmetros
        /// </summary>
        public void ProcessarEnderecos()
        {
            var endereco1 = new Endereco();
            var endereco2 = new Endereco();
            var endereco3 = new Endereco();
            var endereco4 = new Endereco();

            SalvarEnderecos(endereco1, endereco2, endereco3, endereco4);
        }

        public void SalvarEnderecos(Endereco endereco1, Endereco endereco2, Endereco endereco3, Endereco endereco4)
        {
            //TODO:Faz algo com os endereços
        }

        #endregion


    }
}
