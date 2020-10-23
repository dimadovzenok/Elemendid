using System.ComponentModel;
using Xamarin.Forms;
using Elemendid.ViewModels;

namespace Elemendid.Views
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