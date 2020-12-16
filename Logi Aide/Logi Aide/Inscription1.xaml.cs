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
    /// Logique d'interaction pour Inscription1.xaml
    /// </summary>
    public partial class Inscription1 : Window
    {
        public Inscription1()
        {
            InitializeComponent();
        }

        private void Button_Annuler1_Click(object sender, RoutedEventArgs e)
        {
            Identification fenetreIdentification = new Identification();
            this.Close();
            fenetreIdentification.Show();
        }

        private void Button_Migrant_Click(object sender, RoutedEventArgs e)
        {
            InscriptionJeune inscriptionJeune = new InscriptionJeune();
            this.Close();
            inscriptionJeune.Show();

        }

        private void Button_Aide_Click(object sender, RoutedEventArgs e)
        {
            InscriptionAide inscriptionAide = new InscriptionAide();
            this.Close();
            inscriptionAide.Show();
        }
    }
}
