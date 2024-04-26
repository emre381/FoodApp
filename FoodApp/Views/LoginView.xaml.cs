using System;
using System.Collections.Generic;
using FoodApp.Models; // Store sınıfını kullanacağız
namespace FoodApp.Views;

public partial class LoginView : ContentPage
{
    private UserModels user;

    public LoginView(UserModels user)
    {
        InitializeComponent();

    }

    private void Button_Clicked(object sender, EventArgs e)
    {
        // Kullanıcıdan girdiği bilgileri al
        string email = EmailEntry.Text;
        string password = PasswordEntry.Text;

        // Giriş bilgilerini doğrula (örneğin, boş olmamalı)
        if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(password))
        {
            DisplayAlert("Error", "Please fill in all fields", "OK");
            return;
        }

        // Gelen kullanıcı bilgilerini kontrol et
        var user = CreateAccountView.userList.Find(u => u.Email == email && u.Password == password);
        if (user != null)
        {
            // Başarılı giriş
            DisplayAlert("Success", "Login successful", "OK");
            // StoresView'e geçiş yap
            Navigation.PushAsync(new StoresView());
        }
        else
        {
            // Hatalı giriş
            DisplayAlert("Error", "Invalid email or password", "OK");
        }
    }

    private async void CreateAccount_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new CreateAccountView());
    }

}
