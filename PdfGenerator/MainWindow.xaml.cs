using System;
using System.Windows;
using System.Collections.Generic;

namespace PdfGenerator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        
        private void BtnClose_Click(Object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void BtnAdd_Click(Object sender, RoutedEventArgs e)
        {
            AddLocataire window = new AddLocataire();
        }
    }
}
