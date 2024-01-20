using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace Task_14
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<Product> products;
        public MainWindow()
        {
            InitializeComponent();
            products =new ObservableCollection<Product>();
            products.Add(new Product()
            {
                ProdName = "Яблоко",
                ProdPrice = 120,
                ProdImage ="Data/яблолко.jpg",
                ProductCategory = ProductCategorys.Food
            });
            products.Add(new Product()
            {
                ProdName = "Суп",
                ProdPrice = 500,
                ProdImage ="Data/Суп.jpg",
                ProductCategory = ProductCategorys.Food
            });
            products.Add(new Product()
            {
                ProdName = "Холодильник",
                ProdPrice = 80000,
                ProdImage ="Data/холодильник.jpg",
                ProductCategory = ProductCategorys.Applinces 
            });
            products.Add(new Product()
            {
                ProdName = "Стиральная машина",
                ProdPrice = 50000,
                ProdImage ="Data/Стир машинка.jpg",
                ProductCategory = ProductCategorys.Applinces
            });
            listBox.ItemsSource = products;
        }
    }
    
}
