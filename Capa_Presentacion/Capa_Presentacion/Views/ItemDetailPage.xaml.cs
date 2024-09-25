using Capa_Presentacion.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace Capa_Presentacion.Views
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