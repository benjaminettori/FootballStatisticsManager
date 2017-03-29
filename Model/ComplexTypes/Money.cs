using FSM.Model.Enums;
using System.ComponentModel.DataAnnotations.Schema;

namespace FSM.Model.ComplexTypes
{
    [NotMapped]
    public class Money
    {
        public decimal Amount { get; set; }
        public Currency Currency { get; set; }
    }
}
