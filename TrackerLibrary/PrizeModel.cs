using System;
using System.Collections.Generic;
using System.Text;

namespace TrackerLibrary
{
    /// <summary>
    /// Représente le prix à gagner à la fin du tournoi pour chaque équipe
    /// </summary>
    public class PrizeModel
    {
        /// <summary>
        /// Représente la place de l'équipe dans le tournoi
        /// </summary>
        public int PlaceNumber { get; set; }

        /// <summary>
        /// Représente le nom de la place
        /// </summary>
        /// <example>
        /// teamName est seconde du tournoi
        /// </example>
        public string PlaceName { get; set; }

        /// <summary>
        /// Représente le montant du prix à gagner
        /// </summary>
        public decimal PrizeAmount { get; set; }

        /// <summary>
        /// Représente le pourcentage de gain du prix
        /// </summary>
        public double PrizePercentage { get; set; }
    }
}
