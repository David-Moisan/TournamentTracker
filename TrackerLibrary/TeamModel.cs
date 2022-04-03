using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    /// <summary>
    /// Représente une équipe dans le tournoi
    /// </summary>
    public class TeamModel
    {
        /// <summary>
        /// Représente la liste des membres d'une équipe
        /// </summary>
        public List<PersonModel> TeamMembers { get; set; } = new List<PersonModel>();

        /// <summary>
        /// Représente le nom de l'équipe
        /// </summary>
        public string TeamName { get; set; }

    }
}
