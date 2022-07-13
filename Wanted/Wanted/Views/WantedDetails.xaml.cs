using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using Wanted.ViewModels;

namespace Wanted.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class WantedDetails : ContentPage
    {
        private readonly SuspectDetailViewModel _spsdtl = new SuspectDetailViewModel();

        public WantedDetails()
        {
            InitializeComponent();
            BindingContext = _spsdtl = new SuspectDetailViewModel();
        }
    }
}