using System;

namespace RefactoringTatics.Source.Domain.Entities
{
    public class Log
    {
        public DateTime Date { get; set; }
        public string StackTrace { get; set; }
        public string  Message { get; set; }
    }
}
