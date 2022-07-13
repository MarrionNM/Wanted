using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Threading.Tasks;

using Xamarin.Forms;

using Wanted.Models;
using Wanted.Views;

namespace Wanted.ViewModels
{
    public class SuspectsViewModel : BaseViewModel
    {
        private SuspectModel _selectedSuspect;

        public ObservableCollection<SuspectModel> Suspects { get; }
        public Command LoadSuspectsCommand { get; }
        public Command AddSuspectCommand { get; }
        public Command<SuspectModel> SuspectTapped { get; }

        public SuspectsViewModel()
        {
            Title = "Most Wanted";
            Suspects = new ObservableCollection<SuspectModel>();
            LoadSuspectsCommand = new Command(async () => await ExecuteLoadSuspectsCommand());

            SuspectTapped = new Command<SuspectModel>(OnSuspectSelected);

            AddSuspectCommand = new Command(OnAddSuspect);
        }

        private async Task ExecuteLoadSuspectsCommand()
        {
            try
            {
                IsBusy = true;
                Suspects.Clear();
                ObservableCollection<SuspectModel> suspects = await DataStore.GetSuspectsAsync(true);
                foreach (SuspectModel suspect in suspects)
                {
                    Suspects.Add(suspect);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
                await Shell.Current.DisplayAlert("error", ex.Message.ToString(), "OK");
            }
            finally
            {
                IsBusy = false;
            }
        }

        public void OnAppearing()
        {
            IsBusy = true;
            SelectedSuspect = null;
        }

        public SuspectModel SelectedSuspect
        {
            get => _selectedSuspect;
            set
            {
                _ = SetProperty(ref _selectedSuspect, value);
                OnSuspectSelected(value);
            }
        }

        private async void OnAddSuspect(object obj)
        {
            await Shell.Current.GoToAsync(nameof(Record));
        }

        private async void OnSuspectSelected(SuspectModel suspect)
        {
            if (suspect == null)
            {
                return;
            }

            // This will push the ItemDetailPage onto the navigation stack
            await Shell.Current.GoToAsync($"{nameof(WantedDetails)}?{nameof(SuspectDetailViewModel.SuspectId)}={suspect.Id}");
        }
    }
}