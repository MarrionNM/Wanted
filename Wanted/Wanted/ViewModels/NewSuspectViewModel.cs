using System;

using Xamarin.Forms;

using Wanted.Models;

namespace Wanted.ViewModels
{
    public class NewSuspectViewModel : BaseViewModel
    {
        private string name;
        private string surname;
        private string picture;

        public NewSuspectViewModel()
        {
            SaveCommand = new Command(OnSave, ValidateSave);
            CancelCommand = new Command(OnCancel);
            PropertyChanged +=
                (_, __) => SaveCommand.ChangeCanExecute();
        }

        private bool ValidateSave()
        {
            return !string.IsNullOrWhiteSpace(name)
                && !string.IsNullOrWhiteSpace(surname)
                && !string.IsNullOrWhiteSpace(picture);
        }

        public string Name
        {
            get => name;
            set => SetProperty(ref name, value);
        }

        public string Surname
        {
            get => surname;
            set => SetProperty(ref surname, value);
        }
        public string Picture
        {
            get => picture;
            set => SetProperty(ref picture, value);
        }

        public Command SaveCommand { get; }
        public Command CancelCommand { get; }

        private async void OnCancel()
        {
            // This will pop the current page off the navigation stack
            await Shell.Current.GoToAsync("..");
        }

        private async void OnSave()
        {
            SuspectModel newSuspect = new SuspectModel()
            {
                Id = Guid.NewGuid().ToString(),
                Name = name,
                Surname = surname,
                Picture = picture
            };

            _ = await DataStore.AddSuspectAsync(newSuspect);

            // This will pop the current page off the navigation stack
            await Shell.Current.GoToAsync("..");
        }
    }
}