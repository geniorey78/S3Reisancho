using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace S3Reisancho
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        private async void btnAbrir_Clicked(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text;
            string clave = txtClave.Text;

            if (usuario == "estudiante2021" && clave == "uisrael2021")
            {
                await Navigation.PushAsync(new ViewDos(usuario, clave));
            }
            else
            {

                await DisplayAlert("Error", "Usuario o clave ingresados incorrectos", "cancel");
                txtUsuario.Text = "";
                txtClave.Text = "";
            }

        }


    }
}
