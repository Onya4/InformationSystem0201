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
    /// Логика взаимодействия для znm.xaml
    /// </summary>
    public partial class znm : Window
    {
        moneyToTableAdapter Information = new moneyToTableAdapter();
        productTableAdapter products = new productTableAdapter();
        stuffTabTableAdapter stuffs = new stuffTabTableAdapter();
        public znm()
        {
            InitializeComponent();
            table.ItemsSource = Information.GetData();
            prodID.ItemsSource = products.GetData();
            prod.DisplayMemberPath = "product_id";
            prod.SelectedValuePath = "product_id";
            stuffID.ItemsSource = stuffs.GetData();
            stuffer.DisplayMemberPath = "FIO";
            stuffer.SelectedValuePath = "employ_id";
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
        }
        private void insert(object sender, RoutedEventArgs e)
        {
            Information.InsertQuery(Convert.ToInt32(prodID.SelectedValue), Convert.ToDouble(count.Text), Convert.ToInt32(stuffID.SelectedValue));
            table.ItemsSource = Information.GetData();
        }
        private void tableChanged(object sender, SelectionChangedEventArgs e)
        {
            var date = table.SelectedItem as DataRowView;
            prodID.SelectedValue = (int)date.Row[0];
            count.Text = (string)date.Row[1];
            stuffID.SelectedValue = (int)date.Row[2];
        }
    }
}
