using System;

namespace RefactoringTatics.Source.BadSmells.DeadCodes
{
    public class DeadCodeResolved
    {
        public string EfetuarRotinaDeCriacaoDeData()
        {
            return DateTime.Now.ToString();
        }
    }
}
