using System;
using System.Collections.Generic;
using System.Data;
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
using System.Xml.Linq;
using WpfApp1.Database1DataSetTableAdapters;

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для SN.xaml
    /// </summary>
    public partial class SN : Window
    {
        complateNormTableAdapter Information = new complateNormTableAdapter();
        stuffTabTableAdapter stuf = new stuffTabTableAdapter();
        normaTableAdapter norm = new normaTableAdapter();
        public SN()
        {
            InitializeComponent();
            table.ItemsSource = Information.GetData();
            stuffer.ItemsSource = stuf.GetData();
            stuffer.DisplayMemberPath = "FIO";
            stuffer.SelectedValuePath = "employ_id";
            norma.ItemsSource = norm.GetData();
            norma.DisplayMemberPath = "standart_name";
            norma.SelectedValuePath = "standart_id";
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
        }
        private void insert(object sender, RoutedEventArgs e)
        {
            Information.InsertQuery(Convert.ToInt32(normal.SelectedValue), Convert.ToInt32(stuff.SelectedValue));
            table.ItemsSource = Information.GetData();
        }
        private void tableChanged(object sender, SelectionChangedEventArgs e)
        {
            var date = table.SelectedItem as DataRowView;
            normal.SelectedValue = (int)date.Row[0];
            stuff.SelectedValue = (int)date.Row[1];
        }
    }
}
