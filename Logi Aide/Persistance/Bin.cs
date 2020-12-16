// ========================================================================
// Classe         : Bin.cs
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
    public class Bin : ISerialiseur
    {

        /// <summary>
        /// Charge les utilisateurs : lit un fichier de sauvegarde (binaire) et retourne les données de ce fichier.
        /// </summary>
        /// <returns>un objet Utilisateurs</returns>
        
        public Utilisateurs Charger()
        {
            Utilisateurs desUtilisateurs = new Utilisateurs();
            Stream fs = File.OpenRead("sauv.txt");
            BinaryReader reader = new BinaryReader(fs);
            //desUtilisateurs = reader.Read();
            fs.Close();
            return desUtilisateurs;
        }

        /// <summary>
        /// Sauvegarde les utilisateurs : créer un fichier puis  écrit en binaire les données à sauvergarder à l'intérieur.
        /// </summary>
        /// <param name="lesUtilisateursASauver"></param>
        /// <returns>1 si la sauvegarde à fonctionner </returns>
        public bool Sauvegarde(Utilisateurs lesUtilisateursASauver)
        {
            Stream fe = File.Create("sauv.txt");
            BinaryWriter writer = new BinaryWriter(fe);
            writer.Write(Convert.ToByte(lesUtilisateursASauver));
            fe.Close();
            return true;
        }


    }
}
