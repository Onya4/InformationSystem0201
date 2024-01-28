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
    /// Логика взаимодействия для WindowDorect.xaml
    /// </summary>
    public partial class WindowDorect : Window
    {
        public WindowDorect()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            MainWindow main = new MainWindow();
            main.Show();
        }

        private void DOPO_Click(object sender, RoutedEventArgs e)
        {
            d0p0 newWind = new d0p0();
            newWind.Show();
        }

        private void KP_Click(object sender, RoutedEventArgs e)
        {
            kp newWind = new kp();
            newWind.Show();
        }

        private void ST_Click(object sender, RoutedEventArgs e)
        {
            st newWind = new st();
            newWind.Show();
        }

        private void SN_Click(object sender, RoutedEventArgs e)
        {
            SN newWind = new SN();
            newWind.Show();
        }

        private void ZNM_Click(object sender, RoutedEventArgs e)
        {
            znm newWind = new znm();
            newWind.Show();
        }

        private void STUFF_Click(object sender, RoutedEventArgs e)
        {
            stuff newWind = new stuff();
            newWind.Show();
        }

        private void T_Click(object sender, RoutedEventArgs e)
        {
            t newWind = new t();
            newWind.Show();
        }

        private void N_Click(object sender, RoutedEventArgs e)
        {
            n newWind = new n();
            newWind.Show();
        }
    }
}
