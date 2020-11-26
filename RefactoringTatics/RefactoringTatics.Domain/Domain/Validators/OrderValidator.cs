using RefactoringTatics.Source.Domain.Entities;

namespace RefactoringTatics.Source.Domain.Validators
{
    public static class OrderValidator
    {
        public static bool ValidateNullOrder(this Order order)
        {
            if (order is null)
                return false;

            return true;
        }
    }
}
