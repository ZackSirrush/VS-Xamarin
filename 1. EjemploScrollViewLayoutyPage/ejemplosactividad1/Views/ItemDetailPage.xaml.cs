using ejemplosactividad1.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace ejemplosactividad1.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}