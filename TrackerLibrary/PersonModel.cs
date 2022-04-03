using System;
using System.Collections.Generic;
using System.Text;

namespace TrackerLibrary
{ 
    /// <summary>
    /// Représente une personne faisant partie d'une équipe
    /// </summary>
    public class PersonModel
    {
        /// <summary>
        /// Représente le prénom du membre de l'équipe
        /// </summary>
        public string FirstName { get; set; }
        
        /// <summary>
        /// Représente le nom de famille du membre de l'équipe
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// Représente l'adresse mail du membre de l'équipe
        /// </summary>
        public string EmailAddress { get; set; }

        /// <summary>
        /// Représente le numéro de téléphone du membre de l'équipe
        /// </summary>
        public string CellphoneNumber { get; set; }
    }
}
