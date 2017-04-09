using System;

namespace FSM.DomainModel.Exceptions
{
    public class IncorrectPlayerInformationException : Exception
    {
        public IncorrectPlayerInformationException(string message) : base(message) { }
    }
}
