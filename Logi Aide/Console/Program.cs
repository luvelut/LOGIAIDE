// ========================================================================
// Classe         : Program.cs
// Auteurs        : VELUT Lucile & MOURGUES Théo
// ========================================================================


using System;
using Data;
using Modele;
using static System.Console;
using static System.Text.Encoding;


namespace ConsoleTest
{
    class Program
    {
        static void Main(string[] args)
        {
            //TEST DE LA CLASSE JEUNE
            WriteLine("Voici un jeune :\n");
            Inscrit unJeune = Stub.CreationJeuneTest();
            Console.WriteLine(unJeune.ToString());

            //TEST DE LA CLASSE AIDE
            WriteLine("Voici une aide :\n");
            Inscrit uneAide = Stub.CreationAideTest();
            WriteLine(uneAide.ToString());


            //TEST DE LA CLASSE UTILISATEURS
            WriteLine("Voici des utilisateurs :\n");
            Utilisateurs utilisateurs = Stub.CreationUtilisateursTest();

            foreach (Inscrit inscrit in utilisateurs.CollectionInscrits)
            {
                Console.WriteLine(inscrit.ToString());
            }
        }
    }
}
