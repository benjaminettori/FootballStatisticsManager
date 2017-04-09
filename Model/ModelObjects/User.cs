using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace FSM.Model.ModelObjects
{
    [Table("User")]
    public class User : BaseObject
    {         
        public string FirstName { get; set; }
        public string LastName { get; set; }   
        public string UserName { get; set; }
    }
}
