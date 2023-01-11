﻿using System.Windows;
using System.Windows.Controls;

namespace PL
{

    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private BlApi.IBl? bl = BlApi.Factory.Get();

        public BO.Cart currentCart
        {
            get { return (BO.Cart)GetValue(currentCartProperty); }
            set { SetValue(currentCartProperty, value); }
        }

        // Using a DependencyProperty as the backing store for currentCart.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty currentCartProperty =
            DependencyProperty.Register("currentCart", typeof(BO.Cart), typeof(Window), new PropertyMetadata(null));

        public MainWindow()
        {
            InitializeComponent();
        }
        private void ShowFollowOrdersButton_Click(object sender, RoutedEventArgs e) => new Order.FollowOrderPopUpWindow().ShowDialog();
        private void ShowCatalogButton_Click(object sender, RoutedEventArgs e) => new Cart.CatalogWindow(currentCart).ShowDialog();
        private void ShowProductsButton_Click(object sender, RoutedEventArgs e) => new Product.ProductListWindow().ShowDialog();
        private void ShowOrdersButton_Click(object sender, RoutedEventArgs e) => new Order.OrderListWindow().ShowDialog();

        private void btnBye_click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

    }
}
