using System;
using System.Collections.Generic;
using FoodApp.Models; // Store sınıfını kullanacağız

namespace FoodApp.Views
{
    public partial class CreateAccountView : ContentPage
    {
        // Geçici olarak kullanıcıları saklayacak bir liste
        public static List<UserModels> userList = new List<UserModels>();

        public CreateAccountView()
        {
            InitializeComponent();
        }

        private async void CreateAccount_Clicked(object sender, EventArgs e)
        {
            // Kullanıcıdan girdiği bilgileri al
            string name = NameEntry.Text;
            string email = EmailEntry.Text;
            string password = PasswordEntry.Text;

            // Giriş bilgilerini doğrula (örneğin, boş olmamalı)
            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(password))
            {
                await DisplayAlert("Error", "Please fill in all fields", "OK");
                return;
            }

            // Kullanıcıyı bir model nesnesi oluşturarak sakla
            UserModels newUser = new UserModels
            {
                Name = name,
                Email = email,
                Password = password
            };

            // İşlem tamamlandıktan sonra bir mesaj göster
            await DisplayAlert("Success", "Account created successfully", "OK");

            // Kayıt işlemi tamamlandıktan sonra login sayfasına yönlendir ve kullanıcı bilgilerini parametre olarak ile
            await Navigation.PushAsync(new LoginView(newUser));
        }


        private void Button_Clicked(object sender, EventArgs e)
        {
            // Kullanıcıdan girdiği bilgileri al
            string name = NameEntry.Text;
            string email = EmailEntry.Text;
            string password = PasswordEntry.Text;

            // Giriş bilgilerini doğrula (örneğin, boş olmamalı)
            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(password))
            {
                DisplayAlert("Error", "Please fill in all fields", "OK");
                return;
            }

            // Aynı email adresiyle kayıtlı bir kullanıcı var mı kontrol et
            foreach (var user in userList)
            {
                if (user.Email == email)
                {
                    DisplayAlert("Error", "This email is already registered", "OK");
                    return;
                }
            }


            // Kullanıcıyı bir model nesnesi oluşturarak sakla
            UserModels newUser = new UserModels
            {
                Name = name,
                Email = email,
                Password = password
            };

            // Kullanıcıyı listeye ekle
            userList.Add(newUser);

            // İşlem tamamlandıktan sonra bir mesaj göster
            DisplayAlert("Success", "Account created successfully", "OK");

            // Kayıt işlemi tamamlandıktan sonra login sayfasına yönlendir
            Navigation.PushAsync(new LoginView(newUser));
        }
    }
}
