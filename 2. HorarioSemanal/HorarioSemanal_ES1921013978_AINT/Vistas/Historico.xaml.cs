using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using static HorarioSemanal_ES1921013978_AINT.Vistas.HorarioP;

namespace HorarioSemanal_ES1921013978_AINT.Vistas
{
    public partial class Historico : ContentPage
    {
        public Historico(List<HorarioP.Actividad>actividades) //Llama la lista anterior y la utiliza para determinar los datos históricos
        {
            InitializeComponent();

            var actividadesPendientes = actividades.Where(a => !a.Realizada).ToList();//Retoma los valores de la lista anterior y define las que están marcadas y desmarcas
            var actividadesRealizadas = actividades.Where(a => a.Realizada).ToList(); //Según su valor se coloca en una u otra tabla

            ListViewPendientes.ItemsSource = actividadesPendientes;
            ListViewRealizadas.ItemsSource = actividadesRealizadas;

        }
    }
}