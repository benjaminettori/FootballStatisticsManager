using System;

namespace FSM.DomainModel.Exceptions
{
    public class IncompleteSkillException : Exception
    {
        public IncompleteSkillException(String message) : base(message)
        {         
        }
    }
}
