using System;
using System.Collections.Generic;
using System.Text;

namespace FSM.DomainModel.Exceptions
{
    public class IncorrectSkillException : Exception
    {
        public IncorrectSkillException(string message) : base(message) { }
    }
}
