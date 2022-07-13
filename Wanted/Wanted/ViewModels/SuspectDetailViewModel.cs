using System;
using System.Diagnostics;

using Xamarin.Forms;

using Wanted.Models;

namespace Wanted.ViewModels
{
    [QueryProperty(nameof(SuspectId), nameof(SuspectId))]
    public class SuspectDetailViewModel : BaseViewModel
    {
        private string suspectidId;

        public string Id { get; set; }
        private string name;
        private string surname;
        private string picture;
        private string hair;
        private string eyes;
        private string height;
        private string race;
        private string nationality;
        private string gender;
        private int age;

        private string caution;
        private string remarks;
        private string reward;

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

        public string Hair
        {
            get => hair;
            set => SetProperty(ref hair, value);
        }
        public string Eyes
        {
            get => eyes;
            set => SetProperty(ref eyes, value);
        }
        public string Height
        {
            get => height;
            set => SetProperty(ref height, value);
        }
        public string Race
        {
            get => race;
            set => SetProperty(ref race, value);
        }
        public string Nationality
        {
            get => nationality;
            set => SetProperty(ref nationality, value);
        }
        public string Gender
        {
            get => gender;
            set => SetProperty(ref gender, value);
        }
        public int Age
        {
            get => age;
            set => SetProperty(ref age, value);
        }

        public string Caution
        {
            get => caution;
            set => SetProperty(ref caution, value);
        }
        public string Remarks
        {
            get => remarks;
            set => SetProperty(ref remarks, value);
        }
        public string Reward
        {
            get => reward;
            set => SetProperty(ref reward, value);
        }

        public string SuspectId
        {
            get => suspectidId;
            set
            {
                suspectidId = value;
                LoadItemId(value);
            }
        }

        public async void LoadItemId(string itemId)
        {
            try
            {
                SuspectModel suspect = await DataStore.GetSuspectAsync(itemId);
                Id = suspect.Id;
                Name = suspect.Name;
                Surname = suspect.Surname;
                Picture = suspect.Picture;
                Hair = suspect.Hair;
                Eyes = suspect.Eyes;
                Height = suspect.Height;
                Race = suspect.Race;
                Nationality = suspect.Nationality;
                Gender = suspect.Gender;
                Age = suspect.Age;

                Reward = suspect.REWARD;
                Remarks = suspect.REMARKS;
                Caution = suspect.CAUTION;
            }
            catch (Exception)
            {
                Debug.WriteLine("Failed to Load Suspect");
            }
        }
    }
}