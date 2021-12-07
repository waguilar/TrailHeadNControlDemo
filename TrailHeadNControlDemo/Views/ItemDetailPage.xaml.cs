using System.ComponentModel;
using TrailHeadNControlDemo.ViewModels;
using Xamarin.Forms;

namespace TrailHeadNControlDemo.Views
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