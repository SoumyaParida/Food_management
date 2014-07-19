using System;
using System.Net;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;

namespace Food_Management
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();

            // Set the data context of the listbox control to the sample data
            DataContext = App.ViewModel;
            /*List<Items> catagory = new List<Items>();
            catagory.Add(new Items() { Name = "Fruits" });
            catagory.Add(new Items() { Name = "Vegitables" });
            catagory.Add(new Items() { Name = "Milk Products" });
            catagory.Add(new Items() { Name = "Bread" });
            catagory.Add(new Items() { Name = "Meat Products" });
            catagory.Add(new Items() { Name = "Juice" });
            catagory.Add(new Items() { Name = "Snacks" });
            this.FoodCatagory.ItemsSource = catagory;*/
        }

        // Load data for the ViewModel Items
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            if (!App.ViewModel.IsDataLoaded)
            {
                App.ViewModel.LoadData();
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            string FoodName = "";
            if (AddFood.Text == "Food Name")
            {
                MessageBox.Show("Please Enter the food name");
                // NavigationService.Navigate(new Uri("/MainPage.xaml?" + FoodName, UriKind.Relative));
            }
            else
            {
                FoodName = AddFood.Text;
                NavigationService.Navigate(new Uri("/Calender.xaml?msg=" + FoodName, UriKind.Relative));
            }
        }

        private void Catagory_list(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Catagory.xaml?", UriKind.Relative));
        }
    }
}