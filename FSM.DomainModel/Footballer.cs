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

        public Footballer(PlayerInformation playerInformation)
        {
            this.playerInformation = playerInformation;
            EnforceValidPlayerInformation();
        }
        
        // Invariant validation
        private void EnforceValidPlayerInformation()
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
        }
    }
}
