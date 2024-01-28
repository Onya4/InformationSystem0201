using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
using System.Xml.Linq;
using WpfApp1.Database1DataSetTableAdapters;

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для d0p0.xaml
    /// </summary>
    public partial class d0p0 : Window
    {
        dateOFTableAdapter Information = new dateOFTableAdapter();
        public d0p0()
        {
            InitializeComponent();
            table.ItemsSource = Information.GetData();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
        }
        private void insert(object sender, RoutedEventArgs e)
        {
            Information.InsertQuery(name.Text, Convert.ToInt32(reg.SelectedValue));
            table.ItemsSource = Information.GetData();
        }
        private void tableChanged(object sender, SelectionChangedEventArgs e)
        {
            var date = table.SelectedItem as DataRowView;
            name.Text = (string)date.Row[0];
            reg.SelectedValue = (int)date.Row[1];
        }
    }
}
