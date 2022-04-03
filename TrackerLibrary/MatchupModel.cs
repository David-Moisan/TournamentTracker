using System;
using System.Collections.Generic;
using System.Text;

namespace TrackerLibrary
{   
    /// <summary>
    /// Représente un match dans le tournoi
    /// </summary>
    public class MatchupModel
    {
        /// <summary>
        /// l'ensemble des équipes qui ont participé à ce match
        /// </summary>
        public List<MatchupEntryModel> Entries { get; set; } = new List<MatchupEntryModel>();

        /// <summary>
        /// Représente l'équipe qui a gagnée le tournoi 
        /// </summary>
        public TeamModel Winner { get; set; }

        /// <summary>
        /// Représente le nombre de tour dans le tournoi
        /// </summary>
        public int MatchupRound { get; set; }
    }
}
