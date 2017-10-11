using System;

namespace FSM.DomainModel.ValueObjects
{
    // This represents the domain object for player attributes
    public class Skill
    {
        public String Name { get; set; }
        public String Code { get; set; }
        public Model.Enums.Attribute SkillAttribute { get; set; }
        public bool Current { get; set; }
        public int Rating { get; set; }
        public DateTime DateAchieved { get; set; }
    }
}
