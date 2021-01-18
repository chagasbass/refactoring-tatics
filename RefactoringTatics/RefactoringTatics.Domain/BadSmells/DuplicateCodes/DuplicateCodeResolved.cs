using RefactoringTatics.Source.Domain.Entities;
using RefactoringTatics.Source.Domain.Validators;
namespace RefactoringTatics.Source.BadSmells.DuplicateCodes
{
    public class DuplicateCodeResolved
    {
        public class DuplicateCode
        {
            public void MyMethod(Customer customer, Order order, Log log)
            {
                //refatorando usando métodos de extensão.
                bool customerIsValid = customer.ValidateNullCustomer();
                bool orderIsValid = order.ValidateNullOrder();
                bool logIsValid = log.ValidateNullLog();

                //TODO:implementação do método.
            }
        }
    }
}
