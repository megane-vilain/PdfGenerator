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
using System.Windows.Shapes;

namespace PdfGenerator
{
    /// <summary>
    /// Interaction logic for AddLocataire.xaml
    /// </summary>
    public partial class AddLocataire : Window
    {
        Locataire _locataire = new Locataire();
        public AddLocataire()
        {
            InitializeComponent();
            this.DataContext = Locataire;
        }

        internal Locataire Locataire { get => _locataire; set => _locataire = value; }

        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
