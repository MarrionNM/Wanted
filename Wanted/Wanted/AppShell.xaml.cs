using System;
using Wanted.Views;
using Xamarin.Forms;

namespace Wanted
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(WantedDetails), typeof(WantedDetails));
            Routing.RegisterRoute(nameof(Record), typeof(Record));
        }

        private async void OnMenuItemClicked(object sender, EventArgs e) => await Shell.Current.GoToAsync("//LoginPage");
    }
}
