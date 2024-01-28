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
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (login.Text == "4567999933" && password.Text == "Direct00")
            {
                this.Hide();
                WindowDorect director = new WindowDorect();
                director.Show();
            }
            else if (login.Text == "4567999934" || login.Text == "4567999935" || login.Text == "4567999936" || login.Text == "4567999937" && password.Text == "Chapte00")
            {
                this.Hide();
                WindowChapter chapter = new WindowChapter();
                chapter.Show();
            }
            else if (login.Text == "4567999921" && password.Text == "Stuff000")
            {
                this.Hide();
                WindowStuff stuff = new WindowStuff();
                stuff.Show();
            }
        }
    }
}
