
using RefactoringTatics.Source.Domain.Entities;
using System;

namespace RefactoringTatics.Source.BadSmells.DuplicateCodes
{
    /// <summary>
    /// Demonstração de Códigos duplicados
    /// 
    /// </summary>
    public class DuplicateCode
    {
        public void MeuMetodo(Customer customer, Order order, Log log)
        {
            if(customer is null)
            {
                throw new ArgumentNullException("O cliente não pode ser nulo");
            }
            if (order is null)
            {
                throw new ArgumentNullException("O pedido não pode ser nulo");
            }
            if (log is null)
            {
                throw new ArgumentNullException("O log não pode ser nulo");
            }

            //TODO:implementação do método.
        }
    }
}
