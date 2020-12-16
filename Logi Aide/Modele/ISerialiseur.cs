// ========================================================================
// Interface      : ISerialiseur.cs
// Auteurs        : VELUT Lucile & MOURGUES Théo
// ========================================================================


using System;
using System.Collections.Generic;
using System.Text;

namespace Modele
{
    public interface ISerialiseur
    {
        Utilisateurs Charger();
        bool Sauvegarde(Utilisateurs lesUtilisateursASauver);


    }
}
