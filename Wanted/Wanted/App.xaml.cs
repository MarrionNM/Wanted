using Wanted.Services;
using Xamarin.Forms;

namespace Wanted
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<SuspectDataStore>();
            MainPage = new AppShell();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
