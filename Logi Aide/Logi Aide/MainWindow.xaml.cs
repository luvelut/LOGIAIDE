using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Modele;
using Data;

namespace Logi_Aide
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public Utilisateurs lesUtilisateurs = Stub.CreationUtilisateursTest();
        public MainWindow()
        {
            InitializeComponent();

            afficheurInscrit.DataContext = lesUtilisateurs;
        }

        public void AjouterJeune (Jeune jeune)
        {
            lesUtilisateurs.AddJeune(jeune);
        }
        public void AjouterAide(Aide aide)
        {
            lesUtilisateurs.AddAide(aide);
        }
        private void Button_Quizz_Click(object sender, RoutedEventArgs e)
        {
            Quizz fenetreQuizz = new Quizz();
            this.Close();
            fenetreQuizz.Show();

        }
    }
}
