// ========================================================================
// Classe         : Inscrit.cs
// Auteurs        : VELUT Lucile & MOURGUES Théo
// ========================================================================


using System;
using System.Collections.Generic;

namespace Modele
{
    /// <summary>
    /// Représente une personne inscrite sur le logiciel (élève/jeune migrant ou professeur/aide)
    /// </summary>
    public abstract class Inscrit : IEquatable<Inscrit>
    {
        public string Nom
        {
            get // public string GetNom()
            {
                return nom;
            }
            private set // private void SetNom(string value)
            {
                nom = value.ToUpper();
            }
        }
        private string nom;
        public string Prenom { get; private set; } //En C# les attributs doivent être déclarés comme des opérations
        public DateTime DateDeNaissance { get; private set; }
        public int Age
        {
            get
            {
                return CalculAge();
            }
        }
        public string Apropos { get; private set; }
        public string Identifiant { get; private set; }

        public String Email { get; set; }
        public String Tel { get; set; }
        public String Image { get; set; }

        /// <summary>
        /// Constructeur d'un Inscrit sur le logiciel
        /// </summary>
        /// <param name="nom"></param>
        /// <param name="prenom"></param>
        /// <param name="age"></param>
        /// <param name="apropos"></param>
        /// <param name="identifiant"></param>
        /// <param name="dateDeNaissance"></param>
        /// <param name="email"></param>
        /// <param name="tel"></param>
        public Inscrit(string nom, string prenom, DateTime dateDeNaissance, string apropos, string identifiant, string email, string tel, string image)
        {
            Nom = nom;
            Prenom = prenom;
            DateDeNaissance = dateDeNaissance;
            Apropos = apropos;
            Identifiant = identifiant;
            Email = email;
            Tel = tel;
        }

        /// <summary>
        /// Calcul l'age d'un inscrit à partir de sa date de naissance.
        /// </summary>
        /// <returns>l'age de l'inscrit</returns>
        public int CalculAge()
        {

            // Age théorique
            int sonAge = DateTime.Now.Year - DateDeNaissance.Year;

            // Date de l'anniversaire de cette année
            DateTime DateAnniv =
                  new DateTime(DateTime.Now.Year, DateDeNaissance.Month, DateDeNaissance.Day);

            // Si pas encore passé, on retire 1 an
            if (DateAnniv > DateTime.Now)
                sonAge--;

            return sonAge;
        }

        /// <summary>
        /// Méthode toString d'un inscrit
        /// </summary>
        /// <returns>La chaîne de caractère correspondant à son prénom et son nom</returns>
        public override string ToString()
        {
            return $"Je m'appelle {Prenom} {Nom}.\n\n";
        }

        //Protocoles d'égalité 

        public bool Equals(Inscrit other)
        {
            return Nom.Equals(other.Nom) && Prenom.Equals(other.Prenom) && Identifiant.Equals(other.Identifiant);
        }

        public override bool Equals(object obj)
        {
            //On teste si c'est nul
            if (ReferenceEquals(obj, null)) return false;

            //On teste les références
            if (ReferenceEquals(obj, this)) return true;

            //On teste les types
            if (GetType() != obj.GetType()) return false;

            return Equals(obj as Inscrit);
        }

        public override int GetHashCode()
        {
            return Nom.GetHashCode();
        }
    }
}
