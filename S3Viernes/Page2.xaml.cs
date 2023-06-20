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
    public partial class Page2 : ContentPage
    {
        string Usuario;
        public Page2(string usuario)
        {
            InitializeComponent();
            this.Usuario = usuario;
            lblUsuario.Text = usuario;
        }

        private void txtDato_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {

                double dato = Convert.ToDouble(txtDato.Text);
                if (dato > 100)
                {
                    DisplayAlert("Error", "El dato no está en rango", "Cerrar");
                    txtDato.Text = "";
                }
            }
            catch (Exception ex)
            {
                //DisplayAlert("Muerte", "Muerto amiguito :c" + ex, "Cerrar");
            }
        }

        private void btnAbrir_Clicked(object sender, EventArgs e)
        {
            double dato = Convert.ToDouble(txtDato.Text);
            string alumno  = pkAlumnos.Items[pkAlumnos.SelectedIndex];
            Navigation.PushAsync(new Page3(this.Usuario, dato, alumno));
        }
    }
}