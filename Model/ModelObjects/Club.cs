using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FSM.Model.ModelObjects
{
    [Table("Club")]
    public class Club : UserBaseObject
    {       
        [Required]
        public string Name { get; set; }
        public string SixLetterName { get; set; }
        public string NickName { get; set; }

        // Foreign Keys        
        public Guid LeagueId { get; set; }

        // Navigation Properties        
        [ForeignKey("LeagueId")]
        public League League { get; set; }
        
        public ICollection<PlayerContract> PlayerContracts { get; set; }
    }
}
