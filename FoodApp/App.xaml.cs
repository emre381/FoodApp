using FoodApp.Models;
using FoodApp.Views;

namespace FoodApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            // Önceden tanımlı bir kullanıcı oluştur
            UserModels user = new UserModels
            {
                Name = "John",
                Email = "john@example.com",
                Password = "password123"
            };

            // LoginView'i oluştururken kullanıcı bilgilerini geç
            MainPage = new NavigationPage(new LoginView(user));
        }
    }
}