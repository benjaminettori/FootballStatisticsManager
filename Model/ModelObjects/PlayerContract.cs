using FSM.Model.ComplexTypes;
using FSM.Model.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace FSM.Model.ModelObjects
{
    [Table("PlayerContract")]
    public class PlayerContract : UserBaseObject
    {
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public bool Active { get; set; }
        public ContractType Type { get; set; }
        public decimal Amount { get; set; }
        public Currency Currency { get; set; }

        // Navigation Properties
        public Guid ClubId { get; set; }
        public Guid PlayerId { get; set; }
        [ForeignKey("ClubId")]
        public Club Club { get; set; }
        [ForeignKey("PlayerId")]
        public Player Player { get; set; }
        
        public ICollection<PlayerContractClause> Clauses { get; set; }        
    }
}
