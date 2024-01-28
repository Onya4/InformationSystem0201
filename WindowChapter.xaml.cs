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
    /// Логика взаимодействия для WindowChapter.xaml
    /// </summary>
    public partial class WindowChapter : Window
    {
        public WindowChapter()
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

        private void KP_Click_1(object sender, RoutedEventArgs e)
        {
            kp newWind = new kp();
            newWind.Show();
        }

        private void ST_Click_1(object sender, RoutedEventArgs e)
        {
            st newWind = new st();
            newWind.Show();
        }

        private void SN_Click_1(object sender, RoutedEventArgs e)
        {
            SN newWind = new SN();
            newWind.Show();
        }

        private void ZNM_Click_1(object sender, RoutedEventArgs e)
        {
            znm newWind = new znm();
            newWind.Show();
        }

        private void STUFF_Click_1(object sender, RoutedEventArgs e)
        {
            rewSTUFF newWind = new rewSTUFF();
            newWind.Show();
        }

        private void T_Click_1(object sender, RoutedEventArgs e)
        {
            rewT newWind = new rewT();
            newWind.Show();
        }

        private void N_Click_1(object sender, RoutedEventArgs e)
        {
            rewN newWind = new rewN();
            newWind.Show();
        }

       
    }
}
