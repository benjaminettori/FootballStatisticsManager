using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace FSM.Model.ModelObjects
{
    public class PlayerAttribute : BaseObject
    {
        public string AttributeName { get; set; }
        public string AttributeCode { get; set; }
        public DateTime OnDate { get; set; }
        public Attribute Attribute { get; set; }
        public bool Current { get; set; }
        public int Rating { get; set; }

        // Foreign Keys
        public Guid PlayerId { get; set; }
        [ForeignKey("PlayerId")]
        public Player Player { get; set; }

        // TODO: Write these
        private void PopulateAttributeName() { }
        private void PopulateAttributeCode() { }
        private void PopulateAttributeFromCode() { }
    }
}
