using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace TP01
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        async void okClick(object sender, EventArgs e)
        {
            string idValue = id.Text;
            string passwordValue = password.Text;
            if (idValue == "admin" && passwordValue == "senha@dmin")
            {
                await DisplayAlert("Login", "Login realizado com sucesso!", "OK");
            }
            else
            {
                await DisplayAlert("Login", "Login não autorizado", "OK");
            }
        }

        private void limparClick(object sender, EventArgs e)
        {
            id.Text = "";
            password.Text = "";

        }

        async void creditosClick(object sender, EventArgs args)
        {
            await DisplayAlert("Autores", "Lorrane Meneses dos Santos e Igor Nicolas", "OK");
        }
    }
}