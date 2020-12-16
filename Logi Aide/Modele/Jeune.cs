// ========================================================================
// Classe         : Jeune.cs
// Auteurs        : VELUT Lucile & MOURGUES Théo
// ========================================================================


using System;
using System.Collections.Generic;
using System.Text;
using System.Transactions;
using Modele; //En mettant using Modele, on n'est pas obligé d'ajouter
              //Modele. devant le nom des classes (exemple class Jeune:Inscrit est en fait class Jeune:Modele.Inscrit)

namespace Modele
{
    /// <summary>
    /// Représente un élève/jeune migrant
    /// </summary>
    public class Jeune : Inscrit, IEquatable<Jeune> //La classe Inscrit est la classe mère et la classe Jeune est la classe fille
    {
        public string LieuNaissance { get; private set; }
        public string VitAvec { get; private set; }
        public string RaisonImmigration { get; private set; }
        public string RaisonVenue { get; private set; }
        public string Projet { get; private set; }
        public int TitreEtude { get; private set; }
        public int Sante { get; private set; }
        public int SituationSociale { get; private set; }
        public int NiveauFrancais { get; set; }
        public int NiveauMathematiques { get; set; }
        public int OrdrePrio
        {
            get
            {
                return CalculerOrdrePrioriter();
            }
        }


        /// <summary>
        /// Constructeur d'un Jeune (le constructeur appelle "base : ", il appelle donc le constructeur de sa classe mère, la classe Inscrit.)
        /// </summary>
        /// <param name="nom"></param>
        /// <param name="prenom"></param>
        /// <param name="dateDeNaissance"></param>
        /// <param name="apropos"></param>
        /// <param name="id">Identifiant sur le logiciel</param>
        /// <param name="email"></param>
        /// <param name="tel"></param>
        /// <param name="image"></param>
        /// <param name="lieuNaissance"></param>
        /// <param name="vitAvec"></param>
        /// <param name="raisonImm"></param>
        /// <param name="raisonVenue"></param>
        /// <param name="projet"></param>
        /// <param name="titreEtude"></param>
        /// <param name="sante"></param>
        /// <param name="situationSociale"></param>
        /// <param name="niveauFrancais"></param>
        /// <param name="niveauMaths"></param>

        public Jeune(string nom, string prenom, DateTime dateDeNaissance, string apropos, string id, string email, string tel, string image, string lieuNaissance, string vitAvec, string raisonImm, string raisonVenue, string projet, int titreEtude, int sante, int situationSociale) : base(nom, prenom, dateDeNaissance, apropos, id, email, tel, image)
        { 
            LieuNaissance = lieuNaissance;
            VitAvec = vitAvec;
            RaisonImmigration = raisonImm;
            RaisonVenue = raisonVenue;
            Projet = projet;
            TitreEtude = titreEtude;
            Sante = sante;
            SituationSociale = situationSociale;
        }


        /// <summary>
        /// Fonction qui retourne un entier (calcul de l'ordre de priorité en fonction des niveaux de compétence)
        /// </summary>
        /// <returns>Retourne le chiffre de l'ordre de priorité</returns>
        public int CalculerOrdrePrioriter()
        {
            return (TitreEtude + Sante + SituationSociale + NiveauFrancais + NiveauMathematiques)/5; 
        }

        /// <summary>
        /// Méthode toString d'un jeune
        /// </summary>
        /// <returns>La chaîne de caractère correspondant à sa présentation</returns>
        public override string ToString()
        {
            return $"Test de l'age : {Age} \n\nJe m'appelle {Prenom} {Nom} et suis un jeune migrant.\nJe suis né à {LieuNaissance} et je vis avec {VitAvec}.\nOrdre de Priorité : {CalculerOrdrePrioriter()} \n\n";
        }


        // Protocoles d'égalité :
        public bool Equals(Jeune other)
        {
            return Nom.Equals(other.Nom) && Prenom.Equals(other.Prenom) && LieuNaissance.Equals(other.LieuNaissance);
        }
 
        public override bool Equals(object obj)
        {
            //On teste si c'est nul
            if (ReferenceEquals(obj, null)) return false;

            //On teste les références
            if (ReferenceEquals(obj, this)) return true;

            //On teste les types
            if (GetType() != obj.GetType()) return false;

            return Equals(obj as Jeune);
        }

        public override int GetHashCode()
        {
            return Nom.GetHashCode();
        }
    }
}
