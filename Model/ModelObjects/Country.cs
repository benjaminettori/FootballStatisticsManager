using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace FSM.Model.ModelObjects
{
    [Table("Country")]
    public class Country : UserBaseObject
    {       
        public string Name { get; set; }
        public long Population { get; set; }  
        
        // Navigation Properties
        public ICollection<League> Leagues { get; set; }
    }
}
