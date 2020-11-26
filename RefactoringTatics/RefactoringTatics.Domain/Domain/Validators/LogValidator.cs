using RefactoringTatics.Source.Domain.Entities;

namespace RefactoringTatics.Source.Domain.Validators
{
    public static class LogValidator
    {
        public static bool ValidateNullLog(this Log log)
        {
            if (log is null)
                return false;

            return true;
        }
    }
}
