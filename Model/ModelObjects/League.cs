using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace FSM.Model.ModelObjects
{
    [Table("League")]
    public class League : UserBaseObject
    {        
        public string Name { get; set; }
        public int Tier { get; set; }

        // Foreign Key        
        public Guid CountryId { get; set; }       
        [ForeignKey("CountryId")]
        public Country Country { get; set; }
    }
}
