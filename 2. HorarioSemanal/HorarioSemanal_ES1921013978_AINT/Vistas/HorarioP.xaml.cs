
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HorarioSemanal_ES1921013978_AINT.Vistas
{
    public partial class HorarioP : ContentPage
    {
        private ObservableCollection<Actividad> actividades; //Observa la colección de datos para la listView
        public HorarioP()
        {
            InitializeComponent();

            actividades = new ObservableCollection<Actividad>(); //Añade una colección para el ListView
            ListViewActividades.ItemsSource = actividades; //Inicializa la ListView

        }

        private void AgregarActividad_Clicked(object sender, EventArgs e) //Al hacer clic en el botón
        {
            string nuevaActividadNombre = NombreEntry.Text; //Guarda los valores de los campos seleccionados
            DateTime nuevaActividadFecha = SelectorFecha.Date;
            TimeSpan nuevaActividadHora = SelectorHora.Time;
            bool actividadRealizada = false;

            if(actividadRealizadaCB.IsChecked) //Sí está marcado el checkbox
            {
                actividadRealizada = actividadRealizadaCB.IsChecked; //Indica que la actividad está realizada
            }

            Actividad nuevaActividad = new Actividad //Llama una nueva instancia de la clase actividad
            {
                Nombre = nuevaActividadNombre, 
                Realizada = actividadRealizada,
                Fecha = nuevaActividadFecha.ToString("dd/MM/yyyy"),
                Hora = nuevaActividadHora.ToString()
            };

            actividades.Add(nuevaActividad); //Añade actividad al list view

            NombreEntry.Text = string.Empty; //Limpia los valores para el formulario
            SelectorFecha.Date = DateTime.Now;
            SelectorHora.Time = new TimeSpan(0, 0, 0);
            actividadRealizadaCB.IsChecked = false;

        }
        public class Actividad //Establece getters y setters para la clase actividad
        {
            public string Nombre { get; set; }
            public bool Realizada { get; set; }
            public string Fecha { get; set; }
            public string Hora { get; set; }
        }

        private void IrHistorico_Clicked(object sender, EventArgs e) //Redireccóna al histórico de la aplicación
        {
            Navigation.PushAsync(new Historico(actividades.ToList()));//Manda los datos de las actividades para su clasificación
        }
    }
}