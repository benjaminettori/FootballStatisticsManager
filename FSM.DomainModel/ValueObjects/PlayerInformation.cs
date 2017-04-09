using System;

namespace FSM.DomainModel.ValueObjects
{
    public class PlayerInformation
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int Height { get; set; }
        public int Weight { get; set; }
        public string RightFootRating { get; set; }
        public string LeftFootRating { get; set; }
    }
}
