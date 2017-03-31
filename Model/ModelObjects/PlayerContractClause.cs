using FSM.Model.Enums;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FSM.Model.ModelObjects
{
    [Table("PlayerContractClause")]
    public class PlayerContractClause : UserBaseObject
    {
        [Required]
        public PlayerContractClauseType ClauseType { get; set; }
        public decimal ClauseValue { get; set; }
        public decimal? SecondClauseValue { get; set; }

        // Navigation Properties
        public Guid ContractId { get; set; }
        [ForeignKey("ContractId")]
        public PlayerContract Contract { get; set; }
    }
}
