using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Regla_Cramer_ES1921013978_AINT.Vistas;

namespace Regla_Cramer_ES1921013978_AINT
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        private void btnresolver_Clicked(object sender, EventArgs e)
        {
            string valorx1 = x1.Text; //Retoma los valores de los entry y los almacena como string
            string valory1 = y1.Text;
            string valorz1 = z1.Text;
            string valorx2 = x2.Text;
            string valory2 = y2.Text;
            string valorz2 = z2.Text;

            //Se crea una clase que contenga los valores almacenados
            Resultados envíavalores = new Resultados(valorx1,valory1,valorz1, valorx2,valory2,valorz2);

            Navigation.PushAsync(envíavalores); //Se envían los valores a la página siguiente

            x1.Text = string.Empty; //Limpia las casillas que se llenaron
            x2.Text = string.Empty;
            y1.Text = string.Empty;
            y2.Text = string.Empty;
            z1.Text = string.Empty;
            z2.Text = string.Empty;
        }
    }
}
