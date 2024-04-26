using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using FoodApp.Models;

namespace FoodApp.Views
{
    public partial class StoresView : ContentPage
    {
        public ICommand SearchCommand => new Command<String>(Search);
        public List<Store> Stores { get; set; }

        public StoresView()
        {
            InitializeComponent();
            LoadData();
            BindingContext = this;
        }


        private void Search(string query)
        {
            // Perform search logic here
        }
        private void LoadData()
        {
            Stores = new List<Store>
            {
                new Store
                {
                    Id = 1,
                    Header = "hamburger.jpg",
                    Logo = "farmlogo.png",
                    Name = "maugly",
                    DeliveryTime = "30 - 60 mins",
                    Minimum = 50,
                    ServiceFee = 10,
                    Rating = 4.5
                },
                new Store
                {
                    Id = 2,
                    Header = "pizza.jpg",
                    Logo = "bull.jpg",
                    Name = "pizzaLa",
                    DeliveryTime = "45 - 60 mins",
                    Minimum = 5,
                    ServiceFee = 15,
                    Rating = 4.3
                },
                new Store
                {
                    Id = 3,
                    Header = "salad.jpg",
                    Logo = "bull.jpg",
                    Name = "SaladIsHere",
                    DeliveryTime = "45 - 60 mins",
                    Minimum = 5,
                    ServiceFee = 15,
                    Rating = 4.3
                },
                new Store
                {
                    Id = 4,
                    Header = "vegan.jpg",
                    Logo = "farmlogo.png",
                    Name = "VegansN",
                    DeliveryTime = "45 - 60 mins",
                    Minimum = 5,
                    ServiceFee = 15,
                    Rating = 4.3
                },
                new Store
                {
                    Id = 5,
                    Header = "pasta.jpg",
                    Logo = "bull.jpg",
                    DeliveryTime = "45 - 60 mins",
                    Minimum = 5,
                    ServiceFee = 15,
                    Rating = 4.3
                }
            };
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ProfileView());
        }
    }
}
