using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace repaso
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page2 : ContentPage
    {
        String usuario1;
        public Page2( string usuario)
        {
            InitializeComponent();
            lblUsuario.Text = "Usuario Conectado: " + usuario;
            usuario1 = usuario;

        }

        private void txtdato_TextChanged(object sender, TextChangedEventArgs e)
        {
            double dato = Convert.ToDouble(txtdato.Text);


            try
            {
                if (dato > 100)
                {
                    DisplayAlert("Error", "El dato no esta en rango", "Cerrar");
                }
            

            }
            catch (Exception ex)
            {

            }

        }

        private void botonAbrir_Clicked(object sender, EventArgs e)
        {
            double dato =Convert.ToDouble(txtdato.Text);
            string alumno = plAlumnos.Items[plAlumnos.SelectedIndex];
            Navigation.PushAsync(new Page3(usuario1,dato, alumno)); 

        }
    }

     
}

