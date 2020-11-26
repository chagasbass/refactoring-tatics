using RefactoringTatics.Source.Domain.Entities;

namespace RefactoringTatics.Source.Domain.Validators
{
    public static class CustomerValidator
    {
        public static bool ValidateNullCustomer(this Customer customer)
        {
            if (customer is null)
                return false;

            return true;
        }
    }
}
