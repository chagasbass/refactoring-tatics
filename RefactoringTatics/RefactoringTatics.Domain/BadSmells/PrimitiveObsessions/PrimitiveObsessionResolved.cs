using RefactoringTatics.Source.BadSmells.PrimitiveObsessions.ValueObjects;

namespace RefactoringTatics.Source.BadSmells.PrimitiveObsessions
{
    /// <summary>
    /// Demonstração de Primitive Obsession
    /// refatorada eliminando os tipos primitivos usando uma classe (Endereco) que agrega todas as informações
    /// </summary>
    public class PrimitiveObsessionResolved
    {
        public int Id { get; set; }

        public Endereco Endereco { get; set; }

        public PrimitiveObsessionResolved(Endereco endereco)
        {
            Endereco = endereco;
        }
    }
}
