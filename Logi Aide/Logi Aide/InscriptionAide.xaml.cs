using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Modele;
using System.Runtime.InteropServices;
using Data;

namespace Logi_Aide
{
    /// <summary>
    /// Logique d'interaction pour InscriptionAide.xaml
    /// </summary>
    public partial class InscriptionAide : Window
    {
        public Utilisateurs LesUtilisateurs { get; set; }


        public InscriptionAide()
        {
            InitializeComponent();

            LesUtilisateurs = Stub.CreationUtilisateursTest();
            InfosAides.DataContext = LesUtilisateurs;
        }

        private void Button_Valider_Click(object sender, RoutedEventArgs e)
        {
            string nom = TextNom.Text;
            string prenom = TextPrenom.Text;
            DateTime dateDeNaissance = DateTime.Today;
            dateDeNaissance = TextDate.DisplayDate;
            string tel = TextTel.Text;
            string email = TextMail.Text;
            string apropos = TextApropos.Text;
            string id = TextId.Text;
            string competence = TextComp.Text;
            string creneaux = TextCreneaux.Text;
            string image = TextImage.Text;
            Boolean aideMath = false;
            if(CheckBox_Maths.IsChecked==true)
            {
                aideMath = true;
            }            
            Boolean aideFrancais = false;
            if(CheckBox_Fr.IsChecked==true)
            {
                aideFrancais = true;
            }            
            Boolean aideSante = false;
            if(CheckBox_Sante.IsChecked==true)
            {
                aideSante = true;
            }            
            Boolean aideSocial = false;
            if(CheckBox_Aide.IsChecked==true)
            {
                aideSocial = true;
            }

            // Cherche à savoir si tout les paramètres sont bien remplis.
            if (string.IsNullOrEmpty(nom) || string.IsNullOrEmpty(prenom) || dateDeNaissance == DateTime.Today || string.IsNullOrEmpty(apropos) || string.IsNullOrEmpty(id) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(tel) || string.IsNullOrEmpty(competence) || string.IsNullOrEmpty(creneaux) || string.IsNullOrEmpty(image))
            {
                MessageBox.Show("Veuillez renseigner tous les champs");
            }
            else
            {
                MainWindow mainWindow = new MainWindow();
                mainWindow.AjouterAide(new Aide(nom, prenom, dateDeNaissance, apropos, id, email, tel, image, competence, creneaux, aideMath, aideFrancais, aideSante, aideSocial));
                this.Close();
                mainWindow.Show();
            }
        }

        private void Button_Annuler_Click(object sender, RoutedEventArgs e)
        {
            Inscription1 inscription1 = new Inscription1();
            this.Close();
            inscription1.Show();
        }

        private void Button_Parcourir_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Fichiers images| *.jpg;*.png;*.gif;*.bmp";
            bool? retour = dialog.ShowDialog();
            if (retour == true)
            {
                string fichier = dialog.FileName;
            }

        }
    }
}
