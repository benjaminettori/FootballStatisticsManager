using FSM.Model.Enums;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace FSM.Model.ModelObjects
{
    public class PlayerPosition : BaseObject
    {
        public PositionRating Rating { get; set; }
        public DateTime OnDate { get; set; }
        
        // Navigation Properties
        public Guid PlayerId { get; set; }
        [ForeignKey("PlayerId")]
        public Player Player { get; set; }
    }
}
