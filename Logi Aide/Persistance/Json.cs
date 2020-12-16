// ========================================================================
// Classe         : Json.cs
// Auteurs        : VELUT Lucile & MOURGUES Théo
// ========================================================================


using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modele;
using System.Runtime.Serialization;

namespace Persistance
{
    public class Json : ISerialiseur
    {

        public Utilisateurs Charger(String chemin)
        {
            Utilisateurs desUtilisateurs = new Utilisateurs();
            Stream fs = File.OpenRead(chemin);
            //Ecrire une ligne où on converti les données de Json en Objet Utilisateur
            //Ecrire une ligne où lit les utilisateurs (ReadObject)
            fs.Close();
            return desUtilisateurs;

        }

        public bool Sauvegarder(String chemin, Utilisateurs lesUtilisateursASauver)
        {
            //Ecrire une ligne où on converti les données de Objet en Json
            Stream fe = File.Create(chemin);
            //Ecrire une ligne où on écrit lesUtilisateursASauver dans le fichier (WriteObject)
            fe.Close();
            return true;
        }

    }
}
