using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace FSM.Model.ModelObjects
{
    public class Club
    {       
        public string Name { get; set; }

        // Foreign Keys
        public Guid CountryId { get; set; }
        public Guid LeagueId { get; set; }        

        [ForeignKey("CountryId")]
        public Country Country { get; set; }
        [ForeignKey("LeagueId")]
        public League League { get; set; }        
    }
}
