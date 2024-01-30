using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration;
using Xamarin.Forms.Xaml;

namespace Regla_Cramer_ES1921013978_AINT.Vistas
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Resultados : ContentPage
	{
		public Resultados(string valorx1, string valory1, string valorz1, string valorx2, string valory2, string valorz2)
		{
			InitializeComponent(); //recibe los valores enviados en la página anterior

            //Se delcaran variables
            double d, dx, dy, rx, ry;

			//Los valores que se reciben desde la página principal deben convertirse en números, se elige double para trabajar con variables de punto decimal
			if(double.TryParse(valorx1, out double x1) &&
                double.TryParse(valory1, out double y1) &&
                double.TryParse(valorz1, out double z1) &&
                double.TryParse(valorx2, out double x2) &&
                double.TryParse(valory2, out double y2) &&
                double.TryParse(valorz2, out double z2)){

                //Se realizan las operaciones necesarias
                d = (x1 * y2) - (y1 * x2);                
                if (d != 0)
                {
                    dx = (z1 * y2) - (y1 * z2);
                    dy = (x1 * z2) - (z1 * x2);
                    rx = (dx / d);
                    ry = (dy / d);

                    //Se añaden los resultados a las etiquetas establecidas.
                    determinanteSistema.Text = $"D = ({valorx1} * {valory2}) - ({valory1}*{valorx2}) = {d}";
                    determinanteX.Text = $"Dx = ({valorz1} * {valory2})-({valory1}*{valorz2}) = {dx}";
                    determinanteY.Text = $"Dy = ({valorx1}*{valorz2})-({valorz1}*{valorx2}) = {dy}";
                    resultadosX.Text = $"X = Dx / D = {dx} / {d} = {rx}";
                    resultadosY.Text = $"Y = Dy / D = {dy} / {d} = {ry}";
                } else
                {
                    DisplayAlert("Mensaje","El sistema no cuenta con solución", "Aceptar"); //Sí se ingresan valores en 0 o no hay solución
                }             
            }
            else
            {
                //Mensaje de error en caso de que los valores no sean correctos
                DisplayAlert("Error", "Ingrese valores numéricos válidos", "Aceptar");
            }
        }

        private void btnsalir_Clicked(object sender, EventArgs e)
        {
            if(Device.RuntimePlatform == Device.Android) //Cierra aplicación según su plataforma
            {
                System.Diagnostics.Process.GetCurrentProcess().Kill(); //Sí es android usa este código
            } else if(Device.RuntimePlatform == Device.iOS || Device.RuntimePlatform == Device.UWP) //iOS o UWP
            {
                Application.Current.MainPage = new NavigationPage(new MainPage()); //Otra plataforma devolverá a la página principal
            }
        }

        private async void regresar_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync(); //Permite regresar a la página anterior
        }
    }
}