using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Semana2
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Login : ContentPage
    {
        public Login()
        {
            InitializeComponent();
        }

        private async void btnIniciar_Clicked(object sender, EventArgs e)
        {
            //await Navigation.PushAsync(new Registro(txtUsuario.Text));
            string usuario = "jguaman";
            string contrasena = "123";

            string tUsuario = txtUsuario.Text;
            string tContrasena = txtontrasena.Text;

            if(usuario == tUsuario & contrasena == tContrasena)
            {
                
                DisplayAlert("Alerta", "USUARIO CORRECTO", "Cerrar");
                await Navigation.PushAsync(new Registro(txtUsuario.Text, txtontrasena.Text));
            }
            else
                DisplayAlert("Alerta", "USUARIO INCORRECTO", "Cerrar");
        }
    }
}