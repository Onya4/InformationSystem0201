using Microsoft.SqlServer.Server;
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
    /// Логика взаимодействия для st.xaml
    /// </summary>
    public partial class st : Window
    {
        complateTrebTableAdapter Information = new complateTrebTableAdapter();
        productTableAdapter products = new productTableAdapter();
        requirTableAdapter reqiers = new requirTableAdapter();
        public st()
        {
            InitializeComponent();
            table.ItemsSource = Information.GetData();
            prodID.ItemsSource = products.GetData();
            prod.DisplayMemberPath = "product_id";
            prod.SelectedValuePath = "product_id";
            reqID.ItemsSource = reqiers.GetData();
            requ.DisplayMemberPath = "requirement_name";
            requ.SelectedValuePath = "requirement_id";
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
        }
        private void insert(object sender, RoutedEventArgs e)
        {
            Information.InsertQuery(Convert.ToInt32(reqID.SelectedValue), Convert.ToInt32(prodID.SelectedValue), Convert.ToInt32(number.SelectedValue));
            table.ItemsSource = Information.GetData();
        }
        private void tableChanged(object sender, SelectionChangedEventArgs e)
        {
            var date = table.SelectedItem as DataRowView;
            reqID.SelectedValue = (int)date.Row[0];
            prodID.SelectedValue = (int)date.Row[1];
            number.SelectedValue = (int)date.Row[2];
        }
    }
}
