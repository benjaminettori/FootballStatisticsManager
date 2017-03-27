using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace FSM.Model.ModelObjects
{
    public class PlayerStatistic : BaseObject
    {
        public double Value { get; set; }
        public DateTime OnDate { get; set; }

        // ForeignKeys
        public Guid CategoryId { get; set; }
        public Guid PlayerId { get; set; }
        public Guid SeasonId { get; set; }
        [ForeignKey("CategoryId")]
        public StatisticalCategory Category { get; set; }
        [ForeignKey("PlayerId")]
        public Player Player { get; set; }
        [ForeignKey("SeasonId")]
        public Season Season { get; set; }
    }
}
