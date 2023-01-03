using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppLoginS3
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class login : ContentPage
    {
        public login()
        {
            InitializeComponent();

        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            String sUsuario = txtUsuario.Text;
            String sContraseña = txtContraseña.Text;

            if((sUsuario == "estudiante2022" ) && (sContraseña == "uisrael2022"))
            {
                Navigation.PushAsync(new Dashboard());

            }
            else
            {
                lblResultado.Text = "El usuario o contraseña es incorrecto";
            }
    }
}
}
