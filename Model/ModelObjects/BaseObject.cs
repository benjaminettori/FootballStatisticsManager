using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace FSM.Model.ModelObjects
{
    public class BaseObject
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }        

        public DateTime Created { get; set; }
        public DateTime LastUpdated { get; set; }
    }
}
