using Osztályok;
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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        List<Tartaly> tartalyok = new List<Tartaly>();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnFelvesz_Click(object sender, RoutedEventArgs e)
        {
            //  Tartaly tartaly = new Tartaly(txtNev.Text,int.Parse(txtAel), txtBel.Text, txtCel.Text)
            // lbTartalyok.Items.Add();
        }

        private void btnRogzit_Click(object sender, RoutedEventArgs e)
        {

        }

        private void rdoKocka_Checked(object sender, RoutedEventArgs e)
        {
            txtAel.IsEnabled = false;
            txtAel.Text = "10";

            txtBel.IsEnabled = false;
            txtBel.Text = "10";

            txtCel.IsEnabled = false;
            txtCel.Text = "10";

        }

        private void rdoTeglatest_Checked(object sender, RoutedEventArgs e)
        {
            txtAel.IsEnabled = true;
            txtBel.IsEnabled = true;
            txtCel.IsEnabled = true;
        }
    }
}