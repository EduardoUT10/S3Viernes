using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace S3Viernes
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page1 : ContentPage
    {
        public Page1()
        {
            InitializeComponent();
        }

        private void btnInicio_Clicked(object sender, EventArgs e)
        {
            string usuario = "uisrael";
            string contrasenia = "2023";
            if (txtUsuario.Text == usuario && txtContrasenia.Text == contrasenia)
            {
                Navigation.PushAsync(new Page2(usuario));
            }
            else
            {
                DisplayAlert("Error", "Usuario o contraseña incorrectos", "Cerrar");
            }
        }

        private void btnCancelar_Clicked(object sender, EventArgs e)
        {

        }
    }
}