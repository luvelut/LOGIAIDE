// ========================================================================
// Classe         : Utilisateurs.cs
// Auteurs        : VELUT Lucile & MOURGUES Théo
// ========================================================================

using System;
using System.Collections.Generic;
using System.Text;

namespace Modele
{
    public class Utilisateurs : IEquatable<Utilisateurs>
    {
        public List<Inscrit> CollectionInscrits { get; set; } = new List<Inscrit>();

        public void AddJeune(Jeune unJeune)
        {
            CollectionInscrits.Add(unJeune);
        }

        public void AddAide(Aide uneAide)
        {
            CollectionInscrits.Add(uneAide);
        }

        //Protocoles d'égalité 

        //Compare un Utilisateur avec un autre utilisateur
        public bool Equals(Utilisateurs other)
        {
            return CollectionInscrits.Equals(other.CollectionInscrits);
        }

        //Compare un Utilisateur avec un objet lambda
        public override bool Equals(object obj)
        {
            //On teste si c'est nul
            if (ReferenceEquals(obj, null)) return false;

            //On teste les références
            if (ReferenceEquals(obj, this)) return true;

            //On teste les types
            if (GetType() != obj.GetType()) return false;

            return Equals(obj as Utilisateurs);
        }

        public override int GetHashCode()
        {
            return CollectionInscrits.GetHashCode();
        }
    }
}
