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

namespace AgendaApp
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
            //MessageBox.Show(TxtNome.Text);
            Contato c = new Contato(TxtNome.Text, TxtEmail.Text, TxtTel.Text);
            List.Items.Add(c);
      }
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (List.SelectedItem != null)
                List.Items.Remove(List.SelectedItem);
        }
    }
}
