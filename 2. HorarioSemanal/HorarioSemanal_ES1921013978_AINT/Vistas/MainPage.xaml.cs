
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using HorarioSemanal_ES1921013978_AINT.Vistas;

namespace HorarioSemanal_ES1921013978_AINT
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void btnhorario_Clicked(object sender, System.EventArgs e) //Configura el botón de la página principal para iniciar
        {
            Navigation.PushAsync(new HorarioP()); //Debe implementarse el push para redireccionar a la página siguiente
        }
    }
}
