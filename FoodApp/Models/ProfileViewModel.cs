using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace FoodApp.Models
{
    public class ProfileViewModel
    {
        public ICommand PersonalInfoCommand { get; }
        public ICommand CardInfoCommand { get; }
        public ICommand OrderInfoCommand { get; }

        public ProfileViewModel()
        {
            PersonalInfoCommand = new Command(() => DisplayPersonalInfoAlert());
            CardInfoCommand = new Command(() => DisplayCardInfoAlert());
            OrderInfoCommand = new Command(() => DisplayOrderInfoAlert());
        }

        private void DisplayPersonalInfoAlert()
        {
            DisplayAlert("Kişisel Bilgiler", "İsim: xxxx\nSoyisim: xxxx\nE-posta: example@example.com\nTelefon Numarası: 123-456-7890", "Tamam");
        }

        private void DisplayCardInfoAlert()
        {
            DisplayAlert("Kart Bilgileri", "Kart Numarası: XXXX-XXXX-XXXX-1234\nSon Kullanma Tarihi: 12/25\nGüvenlik Kodu: 123", "Tamam");
        }

        private void DisplayOrderInfoAlert()
        {
            DisplayAlert("Sipariş Bilgileri", "Sipariş Numarası: 123456\nSipariş Detayları: ...", "Tamam");
        }

        private async void DisplayAlert(string title, string message, string cancel)
        {
            await Application.Current.MainPage.DisplayAlert(title, message, cancel);
        }
    }
}
