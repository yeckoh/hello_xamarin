using helloxamarin.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace helloxamarin.Views
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