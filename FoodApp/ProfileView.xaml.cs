
using System;
using System.Collections.Generic;
using FoodApp.Models;
namespace FoodApp.Views;

public partial class ProfileView : ContentPage
{
    public ProfileView()
    {
        InitializeComponent();

        PersonalInfoIcon.GestureRecognizers.Add(new TapGestureRecognizer
        {
            Command = new Command(() => DisplayPersonalInfoAlert())
        });

        CardInfoIcon.GestureRecognizers.Add(new TapGestureRecognizer
        {
            Command = new Command(() => DisplayCardInfoAlert())
        });

        OrderInfoIcon.GestureRecognizers.Add(new TapGestureRecognizer
        {
            Command = new Command(() => DisplayOrderInfoAlert())
        });
    }

    private void DisplayPersonalInfoAlert()
    {
        DisplayAlert("Kişisel Bilgiler", "İsim: John\nSoyisim: Doe\nE-posta: example@example.com\nTelefon Numarası: 123-456-7890", "Tamam");
    }
    private void DisplayCardInfoAlert()
    {
        DisplayAlert("Kart Bilgileri", "Kart Numarası: XXXX-XXXX-XXXX-1234\nSon Kullanma Tarihi: 12/25\nGüvenlik Kodu: 123", "Tamam");
    }

    private void DisplayOrderInfoAlert()
    {
        DisplayAlert("Sipariş Bilgileri", "Sipariş Numarası: 123456\nSipariş Detayları: ...", "Tamam");
    }

}