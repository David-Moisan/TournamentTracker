using System;
using System.Collections.Generic;
using System.Text;

namespace TrackerLibrary
{   
    /// <summary>
    /// Représente une équipe dans le match
    /// </summary>
    public class MatchupEntryModel
    {
        /// <summary>
        /// Représente une équipe dans le match
        /// </summary>
        public TeamModel TeamCompeting { get; set; }

        /// <summary>
        /// Représente le score d'une équipe particulière
        /// </summary>
        public double Score { get; set; }

        /// <summary>
        /// Représente le match dont cette équipe est issue en tant que vainqueur
        /// </summary>
        public MatchupModel ParentMatchup { get; set; }
    }
}
