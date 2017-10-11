using FSM.DomainModel.Exceptions;
using FSM.DomainModel.ValueObjects;
using FSM.Model.Enums;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FSM.DomainModel
{
    public class Footballer
    {
        private PlayerInformation playerInformation { get; set; }
        private List<Skill> skills { get; set; }

        public Footballer(PlayerInformation playerInformation, List<Skill> skills)
        {
            this.playerInformation = playerInformation;
            this.skills = skills;
            EnforceValidPlayerData();
        }
        
        // Invariant validation
        private void EnforceValidPlayerData()
        {
            string footRatingErrorMessage = " foot rating value is not in the correct format. Should be one of Very Weak, Weak, Reasonable, Strong, Very Strong.";

            if (string.IsNullOrWhiteSpace(playerInformation.FullName) && (string.IsNullOrWhiteSpace(playerInformation.FirstName) || string.IsNullOrWhiteSpace(playerInformation.LastName)))
                throw new IncompletePlayerInformationException();

            if (playerInformation.DateOfBirth == null) throw new IncompletePlayerInformationException();

            var ratings = Enum.GetValues(typeof(FootRating)).Cast<FootRating>().Select(r => r.ToString("D").ToLowerInvariant()).ToList();

            if (!string.IsNullOrWhiteSpace(playerInformation.RightFootRating))
            {
                string ratingCode = string.Join(" ", playerInformation.RightFootRating).ToLowerInvariant();
                if (!ratings.Contains(ratingCode)) throw new IncorrectPlayerInformationException(string.Format("{0}{1}", "Right", footRatingErrorMessage));                
            }

            if(!string.IsNullOrWhiteSpace(playerInformation.LeftFootRating))
            {
                string ratingCode = string.Join(" ", playerInformation.LeftFootRating).ToLowerInvariant();
                if (!ratings.Contains(ratingCode)) throw new IncorrectPlayerInformationException(string.Format("{0}{1}", "Left", footRatingErrorMessage));
            }

            if (playerInformation.Height <= 0) throw new IncorrectPlayerInformationException("Height cannot be less than 0");
            if (playerInformation.Weight < 0) throw new IncorrectPlayerInformationException("Weight cannot be less than 0");

            // skill validation
            if (skills.Any(s => String.IsNullOrWhiteSpace(s.Name))) throw new IncompleteSkillException("Some skills do not have a name");

            if (skills.Any(s => String.IsNullOrWhiteSpace(s.Code))) throw new IncompleteSkillException("Some skills do not have a code");

            if (skills.Any(s => s.Rating <= 0)) throw new IncorrectSkillException("All skills must have positive rating values.");

            // Add validation to check that each attribute is represented
            // Each attribute should have a current skill rating for the player

            // TODO: For goalkeepers, this validation needs to change
            // TODO: Should the entity be marked as incomplete if attributes are missing, or should an exception be thrown?
            var attributes = Enum.GetValues(typeof(Model.Enums.Attribute)).Cast<Model.Enums.Attribute>();
            if (!attributes.All(a => skills.Where(s => s.Current).Select(s => s.SkillAttribute).Contains(a))) throw new IncompleteSkillException("All attributes must have current value");
        }
    }
}
