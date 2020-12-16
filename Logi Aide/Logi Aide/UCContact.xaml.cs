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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Logi_Aide
{
    /// <summary>
    /// Logique d'interaction pour UCContact.xaml
    /// </summary>
    public partial class UCContact : UserControl
    {
        public UCContact()
        {
            InitializeComponent();

            if(string.IsNullOrEmpty(Ordreprio.Text)!)
            {
                Ordreprio.Background = Brushes.DarkRed;
            }
        }
    }
}
