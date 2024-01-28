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
using WpfApp1.Database1DataSetTableAdapters;

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для stuff.xaml
    /// </summary>
    public partial class stuff : Window
    {
        stuffTabTableAdapter Information = new stuffTabTableAdapter();
        public stuff()
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
            Information.InsertQuery(fio.Text, Convert.ToInt32(pasport.Text), post.Text, Convert.ToInt32(complaince));
            table.ItemsSource = Information.GetData();
        }
        private void tableChanged(object sender, SelectionChangedEventArgs e)
        {
            var date = table.SelectedItem as DataRowView;
            fio.Text = (string)date.Row[1];
            pasport.Text = (string)date.Row[2];
            post.SelectedValue = (string)date.Row[3];
            complaince.SelectedValue = (int)date.Row[4];
        }
        private void delate(object sender, RoutedEventArgs e)
        {
            int id = (int)(table.SelectedItem as DataRowView).Row[0];
            Information.DeleteQuery(id);
            table.ItemsSource = Information.GetData();
        }
        private void update(object sender, RoutedEventArgs e)
        {
            var date = table.SelectedItem as DataRowView;
            Information.UpdateQuery(fio.Text, Convert.ToInt32(pasport.Text), post.Text, Convert.ToInt32(complaince), (int)date.Row[0]);
            table.ItemsSource = Information.GetData();
        }
    }
}
