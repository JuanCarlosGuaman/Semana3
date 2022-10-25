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
    public partial class Registro : ContentPage
    {
        public Registro(String usuario, String contrasena)
        {
            InitializeComponent();
            lblusuario.Text = "El usuario conectado es: " + usuario; 
            lblcontrasena.Text = " La contraseña es: " + contrasena;
        }
        double total;
        double total2;
        public void btnInformacion_Clicked(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            string apellido = txtApellido.Text;

            double nota = Convert.ToDouble(txtNota.Text);
            double nota2 = Convert.ToDouble(txtNota2.Text);
            
            
            nota = nota * 0.3;
            nota2 = nota2 * 0.2;
            total = nota + nota2;
                       
            DisplayAlert("Mensaje de Alerta", "Tu nombre es: \n" + nombre + "\nTu apellido es \n" + apellido + "\nNota Primer parcial \n" + total, "Cerrar");
            
        }
        private void txtNota_TextChanged(object sender, TextChangedEventArgs e)
        {

            double nota = Convert.ToDouble(txtNota.Text);
            
            if (nota > 10)
            {
                DisplayAlert("Mensaje de Alerta", "Debe ingresar un numero entre 1 y 10", "Cerrar");
            }
        }
        private void txtNota2_TextChanged(object sender, TextChangedEventArgs e)
        {
            double nota2 = Convert.ToDouble(txtNota2.Text);
            
            if (nota2 > 10)
            {
                DisplayAlert("Mensaje de Alerta", "Debe ingresar un numero entre 1 y 10", "Cerrar");
            }
           
        }

        public void btnInformacion2_Clicked(object sender, EventArgs e)
        {
            double nota3 = Convert.ToDouble(txtNota3.Text);
            double nota4 = Convert.ToDouble(txtNota4.Text);
            

            nota3 = nota3 * 0.3;
            nota4 = nota4 * 0.2;
            total2 = nota3 + nota4;
            
            DisplayAlert("Mensaje de Alerta", "Nota Segundo parcial \n" + total2, "Cerrar");
        }

        private void txtNota3_TextChanged(object sender, TextChangedEventArgs e)
        {
            double nota3 = Convert.ToDouble(txtNota3.Text);

            if (nota3 > 10)
            {
                DisplayAlert("Mensaje de Alerta", "Debe ingresar un numero entre 1 y 10", "Cerrar");
            }
        }

        private void txtNota4_TextChanged(object sender, TextChangedEventArgs e)
        {
            double nota4 = Convert.ToDouble(txtNota4.Text);

            if (nota4 > 10)
            {
                DisplayAlert("Mensaje de Alerta", "Debe ingresar un numero entre 1 y 10", "Cerrar");
            }
        }

        public void btnInformacion3_Clicked(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            string apellido = txtApellido.Text;
            double totalf;
                      
      
            totalf = total + total2;

            if (totalf >= 7)
            {
                DisplayAlert("Mensaje de Alerta", "Tu nombre es: \n" + nombre + "\nTu apellido es: \n" + apellido + "\nAPROBASTE con: \n" + totalf, "Cerrar");
            }
            else
            {

                DisplayAlert("Mensaje de Alerta", "Tu nombre es: \n" + nombre + "\nTu apellido es: \n" + apellido + "\nREPROBASTE con: \n" + totalf, "Cerrar");
            }
        }
    }
}