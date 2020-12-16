using System;
using System.Collections.Generic;
using System.Text;

namespace Modele
{
    public class Manager
    {
        public Inscrit InscritCourant { get; set; }

        public Utilisateurs UtilisateurCourant { get; private set; }

        public Manager(Utilisateurs utilisateurs)
        {
            UtilisateurCourant = utilisateurs;
        }



    }
}
