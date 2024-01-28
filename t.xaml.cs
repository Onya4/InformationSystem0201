using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection.Emit;
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
    /// Логика взаимодействия для t.xaml
    /// </summary>
    public partial class t : Window
    {
        requirTableAdapter Information = new requirTableAdapter();
        public t()
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
            Information.InsertQuery(treb.Text);
            table.ItemsSource = Information.GetData();
        }
        private void tableChanged(object sender, SelectionChangedEventArgs e)
        {
            var date = table.SelectedItem as DataRowView;
            treb.Text = (string)date.Row[1];
        }
        private void deleta(object sender, RoutedEventArgs e)
        {
            int id = (int)(table.SelectedItem as DataRowView).Row[0];
            Information.DeleteQuery(id);
            table.ItemsSource = Information.GetData();
        }
        private void update(object sender, RoutedEventArgs e)
        {
            var date = table.SelectedItem as DataRowView;
            Information.UpdateQuery(treb.Text, (int)date.Row[0]);
            table.ItemsSource = Information.GetData();
        }
    }
}
