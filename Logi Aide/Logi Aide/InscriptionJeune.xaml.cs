using Microsoft.Win32;
using Modele;
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


namespace Logi_Aide
{
    /// <summary>
    /// Logique d'interaction pour InscriptionJeune.xaml
    /// </summary>
    public partial class InscriptionJeune : Window
    {
        public InscriptionJeune()
        {
            InitializeComponent();
        }

        private void Button_AnnulJeune_Click(object sender, RoutedEventArgs e)
        {
            Inscription1 inscription1 = new Inscription1();
            this.Close();
            inscription1.Show();
        }

        private void Button_ValidJeune_Click(object sender, RoutedEventArgs e)
        {
            string nom = TextNom.Text;
            string prenom = TextPrenom.Text;
            DateTime dateDeNaissance = DateTime.Today;
            dateDeNaissance = TextDate.DisplayDate;
            string tel = TextTel.Text;
            string email = TextMail.Text;
            string lieu = TextLieu.Text;
            string vitAvec = TextVitAvec.Text;
            string raisonImm = TextRaisonImm.Text;
            string raisonVenue = TextRaisonVenue.Text;
            string projet = TextProjet.Text;
            string apropos = TextApropos.Text;
            string id = TextId.Text;
            string image = TextImage.Text;
            int titre = -1;
            if (titre0.IsChecked == true) 
            {
                titre = 5;
            }            
            if (titre1.IsChecked == true) 
            {
                titre = 3;
            }            
            if (titre2.IsChecked == true) 
            {
                titre = 0;
            }
            int sante = -1;
            if (sante0.IsChecked == true) 
            {
                sante = 5;
            }            
            if (sante1.IsChecked == true) 
            {
                sante = 4;
            }            
            if (sante2.IsChecked == true) 
            {
                sante = 2;
            }            
            if (sante3.IsChecked == true) 
            {
                sante = 0;
            }
            int ssociale = -1;
            if (ssociale0.IsChecked == true) 
            {
                ssociale = 5;
            }            
            if (ssociale1.IsChecked == true) 
            {
                ssociale = 4;
            }            
            if (ssociale2.IsChecked == true) 
            {
                ssociale = 2;
            }            
            if (ssociale3.IsChecked == true) 
            {
                ssociale = 0;
            }
            // Cherche à savoir si tout les paramètres sont bien remplis.
            if (string.IsNullOrEmpty(nom) || string.IsNullOrEmpty(prenom) || dateDeNaissance == DateTime.Today || string.IsNullOrEmpty(apropos) || string.IsNullOrEmpty(id) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(tel) || string.IsNullOrEmpty(lieu) || string.IsNullOrEmpty(vitAvec) || string.IsNullOrEmpty(raisonImm) || string.IsNullOrEmpty(raisonVenue) || string.IsNullOrEmpty(projet) || titre==-1 || sante==-1 || ssociale==-1 || string.IsNullOrEmpty(image))
            {
                MessageBox.Show("Veuillez renseigner tous les champs");
            }
            else
            {
                MainWindow mainWindow = new MainWindow();
                mainWindow.AjouterJeune(new Jeune(nom, prenom, dateDeNaissance, apropos, id, email, tel, image, lieu, vitAvec, raisonImm, raisonVenue, projet, titre, sante, ssociale));
                this.Close();
                mainWindow.Show();
            }
        }

        private void Button_Parcourir_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Fichiers images| *.jpg;*.png;*.gif;*.bmp";
            bool? retour = dialog.ShowDialog();
            if(retour==true)
            {
                string fichier = dialog.FileName;
                TextImage.Text = fichier;
            }
        }

        // Permet d'eviter que l'on puisse checker plusieurs checkbox
        private void titre0_Checked(object sender, RoutedEventArgs e)
        {
            titre1.IsChecked = false;
            titre2.IsChecked = false;
        }

        private void titre1_Checked(object sender, RoutedEventArgs e)
        {
            titre0.IsChecked = false;
            titre2.IsChecked = false;
        }

        private void titre2_Checked(object sender, RoutedEventArgs e)
        {
            titre0.IsChecked = false;
            titre1.IsChecked = false;
        }

        private void sante0_Checked(object sender, RoutedEventArgs e)
        {
            sante1.IsChecked = false;
            sante2.IsChecked = false;
            sante3.IsChecked = false;
        }        

        private void sante1_Checked(object sender, RoutedEventArgs e)
        {
            sante0.IsChecked = false;
            sante2.IsChecked = false;
            sante3.IsChecked = false;
        }

        private void sante2_Checked(object sender, RoutedEventArgs e)
        {
            sante0.IsChecked = false;
            sante1.IsChecked = false;
            sante3.IsChecked = false;
        }

        private void sante3_Checked(object sender, RoutedEventArgs e)
        {
            sante0.IsChecked = false;
            sante1.IsChecked = false;
            sante2.IsChecked = false;
        }

        private void ssociale0_Checked(object sender, RoutedEventArgs e)
        {
            ssociale1.IsChecked = false;
            ssociale2.IsChecked = false;
            ssociale3.IsChecked = false;
        }

        private void ssociale1_Checked(object sender, RoutedEventArgs e)
        {
            ssociale0.IsChecked = false;
            ssociale2.IsChecked = false;
            ssociale3.IsChecked = false;
        }

        private void ssociale2_Checked(object sender, RoutedEventArgs e)
        {
            ssociale0.IsChecked = false;
            ssociale1.IsChecked = false;
            ssociale3.IsChecked = false;
        }

        private void ssociale3_Checked(object sender, RoutedEventArgs e)
        {
            ssociale0.IsChecked = false;
            ssociale1.IsChecked = false;
            ssociale2.IsChecked = false;
        }
    }
}
