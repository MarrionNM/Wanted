using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using Wanted.ViewModels;

namespace Wanted.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class WantedList : ContentPage
    {
        private readonly SuspectsViewModel _sps = new SuspectsViewModel();

        public WantedList()
        {
            InitializeComponent();
            BindingContext = _sps = new SuspectsViewModel();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            _sps.OnAppearing();
        }
    }
}