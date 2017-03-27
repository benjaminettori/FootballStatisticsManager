using FSM.Model.Enums;

namespace FSM.Model.ModelObjects
{
    public class StatisticalCategory : BaseObject
    {
        public string CategoryName { get; set; }
        public string CategoryCode { get; set; }
        public CategoryFormat Format { get; set; } 
    }
}
