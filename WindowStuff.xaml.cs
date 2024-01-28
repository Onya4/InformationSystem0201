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

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для WindowStuff.xaml
    /// </summary>
    public partial class WindowStuff : Window
    {
        public WindowStuff()
        {
            InitializeComponent();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            MainWindow main = new MainWindow();
            main.Show();
        }
        private void DOPO_Click(object sender, RoutedEventArgs e)
        {
            rewDOPO newWind = new rewDOPO();
            newWind.Show();
        }
        private void T_Click(object sender, RoutedEventArgs e)
        {
            rewT newWind = new rewT();
            newWind.Show();
        }
        private void N_Click(object sender, RoutedEventArgs e)
        {
            rewN newWind = new rewN();
            newWind.Show();
        }
    }
}
