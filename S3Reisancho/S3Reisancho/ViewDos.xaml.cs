using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace S3Reisancho
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ViewDos : ContentPage
    {
        private string usuario;
        private string clave;

     

        public ViewDos(string usuario, string clave)
        {
            this.usuario = usuario;
            this.clave = clave;

            lblusuario.Text = usuario;
            lblclave.Text = clave;
            txtusuario.Text = usuario;
            txtclave.Text = clave;
        }
    }
}