namespace RefactoringTatics.Source.Domain.Interfaces
{
    public interface IFactory
    {
        object Create(int valor);
        object Make(int valor);
        object NewItem();
    }
}
