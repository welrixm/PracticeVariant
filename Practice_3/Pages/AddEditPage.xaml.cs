using Practice_3.Components;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Practice_3.Pages
{
    /// <summary>
    /// Логика взаимодействия для AddEditPage.xaml
    /// </summary>
    public partial class AddEditPage : Page
    {
        Components.Product product;
        public AddEditPage(Components.Product _product)
        {
            InitializeComponent();
            product = _product;
            DataContext = product;
            TypeCb.ItemsSource = DBConnect.db.Type.ToList();
            TypeCb.DisplayMemberPath = "Name";
            TypeCb.SelectedItem = DBConnect.db.Type.ToList().FirstOrDefault(x => x.Id == product.Id);
            MaterialCb.ItemsSource = DBConnect.db.Material.ToList();
            MaterialCb.DisplayMemberPath = "Name";
            MaterialCb.SelectedItem = DBConnect.db.Material.ToList().FirstOrDefault(x => x.Id == product.Id);
        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {
            if (product.Id == 0)
            {
                DBConnect.db.Product.Add(product);

            }

            DBConnect.db.SaveChanges();
            MessageBox.Show("Успешно сохранено!");
            Navigation.BackPage();
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            Navigation.BackPage();
        }
    }
}
