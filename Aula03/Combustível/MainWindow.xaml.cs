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

namespace Combustível
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Abastecimento x = new Abastecimento();
            x.Setkmr(double.Parse(kmr.Text));
            x.SetValorL(double.Parse(vll.Text)); 
            x.SetValorP(double.Parse(vlp.Text));
            rkm.Text = x.MVkm().ToString("0.00");
            kml.Text = x.Mkml().ToString("0.00");
        }
    }
}
