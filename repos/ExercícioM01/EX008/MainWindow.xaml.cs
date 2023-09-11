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

namespace EX008
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

        private async void btnOk_Click(object sender, RoutedEventArgs e)
        {
            int ini;
            int fm;
            int.TryParse(inicio.Text,out ini);
            int.TryParse(fim.Text, out fm);

            Random random = new Random();
            int sorteado = random.Next(ini, fm+1);

            lblMsg.Content = $"Sorteando entre {ini} e {fm}...";
            await Task.Delay(1000);
            lblMsg.Content = $"O Número Sorteado foi {sorteado}!";
        }
    }
}
