// ========================================================================
// Classe         : Aide.cs
// Auteurs        : VELUT Lucile & MOURGUES Théo
// ========================================================================



using System;
using System.Collections.Generic;
using System.Text;
using Modele;

namespace Modele
{
    /// <summary>
    /// Représente une aide social/un professeur
    /// </summary>
    public class Aide : Inscrit,IEquatable<Aide>
    {
        public string Competence { get; private set; }
        public string Creneaux { get; private set; }
        public bool AideMaths { get; private set; }  //On écrit bool et pas booléan en C# !!
        public bool AideFrancais { get; private set; }
        public bool AideSante { get; private set; }
        public bool AideSocial { get; private set; }


        /// <summary>
        /// Constructeur d'une Aide (le constructeur appelle "base : ", il appelle donc le constructeur de sa classe mère, la classe Inscrit.)
        /// </summary>
        /// <param name="prenom"></param>
        /// <param name="nom"></param>
        /// <param name="dateDeNaissance"></param>
        /// <param name="tel"></param>
        /// <param name="email"></param>
        /// <param name="image"></param>
        /// <param name="aideFrancais"></param>
        /// <param name="aideMaths"></param>
        /// <param name="aideSante"></param>
        /// <param name="aideSocial"></param>
        /// <param name="apropos"></param>
        /// <param name="competence"></param>
        /// <param name="creneaux"></param>
        /// <param name="id"></param>
        public Aide(string nom, string prenom, DateTime dateDeNaissance, string apropos, string id, string email, string tel, string image, string competence, string creneaux, bool aideMaths, bool aideFrancais,bool aideSante, bool aideSocial) : base(nom, prenom,dateDeNaissance, apropos, id, email, tel, image)
        {
            Competence = competence;
            Creneaux = creneaux;
            AideMaths = aideMaths;
            AideFrancais = aideFrancais;
            AideSante = aideSante;
            AideSocial = aideSocial;
        }

        /// <summary>
        /// Méthode toString d'une Aide
        /// </summary>
        /// <returns>La chaîne de caractère correspondant à sa présentation</returns>
        public override string ToString()
        {
            return $"Je m'apelle {Prenom} {Nom} et je suis une aide.\nJe peux aider des jeunes en {Competence}.\n\n";
        }


        // Protocoles d'égalité :

        //Compare une Aide avec une autre Aide
        public bool Equals(Aide other)
        {
            return Nom.Equals(other.Nom) && Prenom.Equals(other.Prenom) && Competence.Equals(other.Competence);
        }

        //Compare une Aide avec un objet lambda
        public override bool Equals(object obj)
        {
            //On teste si c'est nul
            if (ReferenceEquals(obj, null)) return false;

            //On teste les références
            if (ReferenceEquals(obj, this)) return true;

            //On teste les types
            if (GetType() != obj.GetType()) return false;

            return Equals(obj as Aide);
        }

        public override int GetHashCode()
        {
            return Nom.GetHashCode();
        }
    }
}
