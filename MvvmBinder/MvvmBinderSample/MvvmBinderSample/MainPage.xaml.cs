using MvvmBinderSample.ViewModels;
using Xamarin.Forms;

namespace MvvmBinderSample
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            this.BindingContext = new MainPageViewModel();
        }
    }
}
