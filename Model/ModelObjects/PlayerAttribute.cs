using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace FSM.Model.ModelObjects
{
    public class PlayerAttribute : UserBaseObject
    {
        public string AttributeName { get; set; }
        public string AttributeCode { get; set; }
        public DateTime OnDate { get; set; }
        public FSM.Model.Enums.Attribute Attribute { get; set; }
        public bool Current { get; set; }
        public int Rating { get; set; }

        // Foreign Keys
        public Guid PlayerId { get; set; }
        [ForeignKey("PlayerId")]
        public Player Player { get; set; }

        // TODO: Write these
        // Used when reading in data from csv
        private void PopulateAttributeName() { }
        private void PopulateAttributeCode() { }
        private void PopulateAttributeFromCode() { }
    }
}
