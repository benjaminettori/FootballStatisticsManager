using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace FSM.Model.ModelObjects
{
    public class Season : BaseObject
    {       
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        // Foreign Keys
        public Guid LeagueId { get; set; }        

        [ForeignKey("LeagueId")]
        public League League { get; set; }        
    }
}
