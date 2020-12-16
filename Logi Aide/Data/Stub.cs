using System;
using Modele;
// ========================================================================
// Classe         : Stub.cs
// Auteurs        : VELUT Lucile & MOURGUES Théo
// ========================================================================

namespace Data
{
    /// <summary>
    /// Classe dédiées à tester les fonctionnalitées de notre logiciel avec des données en dur.
    /// </summary>
    public class Stub
    {
        /// <summary>
        /// Méthode qui contient les données en dur pour tester la création d'un jeune.
        /// </summary>
        /// <returns>Un jeune de test</returns>
        public static Inscrit CreationJeuneTest()
        {
            Inscrit unEleve = new Jeune("ADA", "Youssef", new DateTime(2000, 04, 17), "A la recherche de cours de français.", "yada", "06 33 48 56 12", "yada@gmail.com", "/Images;Component/1.PNG", "Maroc", "mes parents", "argent", "apprendre", "travailler", 3, 5, 5);
            return unEleve;
        }

        /// <summary>
        /// Méthode qui contient les données en dur pour tester la création d'une Aide.
        /// </summary>
        /// <returns>Une aide de test</returns>
        public static Inscrit CreationAideTest()
        {
            Inscrit uneAide = new Aide("LUIZ", "Maria", new DateTime(1990, 01, 19), "A la recherche de cours d'une aide sociale.", "mluiz", "06 95 84 95 62", "mluiz@gmail.fr", "/Images;Component/5.PNG","langues", "Dimanche", false, true, false, true);
            return uneAide;
        }

        /// <summary>
        /// Méthode qui contient les données en dur pour tester la création des utilisateurs.
        /// </summary>
        /// <returns> Un Objet Utilisateurs (c'est à dire une liste des utilisateurs)</returns>
        public static Utilisateurs CreationUtilisateursTest()
        {
            Utilisateurs testUtilisateurs = new Utilisateurs();
            testUtilisateurs.AddJeune(new Jeune("ADA", "Youssef", new DateTime(2000, 04, 17), "A la recherche de cours de langue.", "jeune1", "07 58 12 45 78", "jeune1@gmail.com", "/Images;Component/1.PNG", "Maroc", "mes parents", "argent", "apprendre", "travailler", 3, 1, 2));
            testUtilisateurs.AddJeune(new Jeune("Kasra", "Jamel", new DateTime(2002, 11, 27), "A la recherche de cours de français.", "jeune2", "06 74 12 45 78", "jeune2@gmail.com", "/Images;Component/2.PNG", "Syrie", "mes parents", "argent", "apprendre", "travailler", 3, 5, 2));
            testUtilisateurs.AddJeune(new Jeune("ALMUSTAPHA", "Lina", new DateTime(2004, 07, 06), "A la recherche de cours.", "jeune3", "07 14 12 47 58", "jeune3@gmail.com", "/Images;Component/6.PNG", "Algérie", "mes parents", "argent", "apprendre", "travailler", 5, 4, 5));

            testUtilisateurs.AddAide(new Aide("LUIZ", "Maria", new DateTime(1990, 01, 19), "Donne des cours de français.", "aide1", "06 85 96 32 12", "aide1@gmail.com", "/Images;Component/5.PNG", "Langues", "Dimanche", false, true, false, true));
            testUtilisateurs.AddAide(new Aide("Lopez", "Romeo", new DateTime(1990, 01, 19), "S'est inscrit pour pouvoir aider les autres.", "aide2", "06 45 82 94 51", "aide2@gmail.com", "/Images;Component/3.PNG", "Langues", "Samedi", true, true, false, false));
            testUtilisateurs.AddAide(new Aide("Dupont", "Benjamin", new DateTime(1990, 01, 19), "Compétent en maths.", "aide3", "06 15 37 84 62", "aide3@gmail.com", "/Images;Component/4.PNG", "Mathématiques", "Samedi et Dimanche", false, false, true, false));

            return testUtilisateurs;
        }

    }
}
