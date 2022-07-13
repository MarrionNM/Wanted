using System;
using Xamarin.Forms;

namespace Wanted.Models
{
    public class SuspectModel
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Aliases { get; set; }
        public string Picture { get; set; }

        //personal details
        public DateTime DateOfBirth { get; set; }
        public int Age { get; set; }
        public string Hair { get; set; }
        public string Eyes { get; set; }
        public string Gender { get; set; }
        public string Nationality { get; set; }
        public string Race { get; set; }
        public string Height { get; set; }

        public DangerLevel DLV { get; set; }

        public string CAUTION { get; set; }
        public string REMARKS { get; set; }
        public string REWARD { get; set; }
    }

    public class DangerLevel
    {
        public string Level { get; set; }
        public Color LevelColor { get; set; }
    }
}
