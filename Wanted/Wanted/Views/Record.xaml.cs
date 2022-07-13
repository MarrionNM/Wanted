using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using Wanted.ViewModels;

namespace Wanted.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Record : ContentPage
    {
        private readonly NewSuspectViewModel _rcd = new NewSuspectViewModel();

        public Record()
        {
            InitializeComponent();
            BindingContext = _rcd = new NewSuspectViewModel();
        }

    }
}