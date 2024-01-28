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
using WpfApp1.Database1DataSetTableAdapters;

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для rewDOPO.xaml
    /// </summary>
    public partial class rewDOPO : Window
    {
        dateOFTableAdapter Information = new dateOFTableAdapter();
        public rewDOPO()
        {
            InitializeComponent();
            table.ItemsSource = Information.GetData();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
        }
    }
}
