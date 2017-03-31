using System;

namespace FSM.Model.ModelObjects
{
    public class UserBaseObject : BaseObject
    {
        public Guid UserId { get; set; }
        public User User { get; set; }
    }
}
