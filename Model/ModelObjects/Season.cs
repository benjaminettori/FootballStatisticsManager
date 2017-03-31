using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace FSM.Model.ModelObjects
{
    [Table("Season")]
    public class Season : UserBaseObject
    {       
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        // Foreign Keys
        public Guid LeagueId { get; set; }        

        [ForeignKey("LeagueId")]
        public League League { get; set; }        
    }
}
