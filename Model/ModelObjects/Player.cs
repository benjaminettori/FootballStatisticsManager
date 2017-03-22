using FSM.Model.Enums;
using System;

namespace FSM.Model.ModelObjects
{
    public class Player : BaseObject
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        // In cm
        public int Height { get; set; }
        // In kg
        public int Weight { get; set; }
        public FootRating RightFootRating { get; set; }
        public FootRating LeftFootRating { get; set; }
    }
}
