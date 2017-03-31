using FSM.Model.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace FSM.Model.ModelObjects
{
    [Table("Player")]
    public class Player : UserBaseObject
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

        // Navigation properties
        public ICollection<PlayerContract> Contracts { get; set; }
    }
}
