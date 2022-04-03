using System;
using System.Collections.Generic;
using System.Text;

namespace TrackerLibrary
{
    /// <summary>
    /// Représente le tournoi
    /// </summary>
    class TournamentModel
    {
        /// <summary>
        /// Représente le nom du tournoi
        /// </summary>
        public string TournamentName { get; set; }

        /// <summary>
        /// Représente le prix d'entré pour participer au tournoi
        /// </summary>
        public decimal EntryFee { get; set; }

        /// <summary>
        /// Représente les équipes ayant réglée le prix d'entré pour participer au tournoi
        /// </summary>
        public List<TeamModel> EnteredTeam { get; set; } = new List<TeamModel>();

        /// <summary>
        /// Représente la liste des prix à gagner
        /// </summary>
        public List<PrizeModel> Prizes { get; set; } = new List<PrizeModel>();

        /// <summary>
        /// Représente le nombre total de tour dans tous le tournoi
        /// </summary>
        public List<List<MatchupModel>> Rounds { get; set; } = new List<List<MatchupModel>>();
    }
}
