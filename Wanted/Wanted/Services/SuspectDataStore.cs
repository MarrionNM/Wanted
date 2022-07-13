using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;

using Wanted.Models;

namespace Wanted.Services
{
    public class SuspectDataStore : SDataStore<SuspectModel>
    {
        private readonly ObservableCollection<SuspectModel> suspects;
        public SuspectDataStore()
        {
            suspects = new ObservableCollection<SuspectModel>()
            {
                new SuspectModel
                {
                    Id = Guid.NewGuid().ToString(), Name = "BHADRESHKUMAR CHETANBHAI", Surname="PATEL", Aliases="Bhadreshkumar C. Patel",
                    Hair="Brown", Eyes="Brown", Height="5'9''", Nationality="Indian", Gender="Male", Age=23, Race="",
                    CAUTION="Bhadreshkumar Chetanbhai Patel is wanted for allegedly killing his wife by striking her multiple times with an object while they were both working at a donut shop in Hanover, Maryland, on April 12, 2015.  A local arrest warrant was issued in the District Court of Maryland for Anne Arundel County on April 13, 2015, and Patel was charged with first degree murder, second degree murder, first degree assault, second degree assault, and dangerous weapon with intent to injure. A federal arrest warrant was issued in the United States District Court, District of Maryland, Baltimore, Maryland, on April 20, 2015, after Patel was charged with unlawful flight to avoid prosecution.", REMARKS="Patel was last known to be in the Newark, New Jersey, area.", REWARD="The FBI is offering a reward of up to $100,000 for information leading to the arrest of Bhadreshkumar Chetanbhai Patel.",
                    Picture="https://www.fbi.gov/wanted/topten/bhadreshkumar-chetanbhai-patel/@@images/image/preview"
                },

                new SuspectModel
                {
                    Id = Guid.NewGuid().ToString(), Name = "ALEJANDRO ROSALES", Surname="CASTILLO", Aliases="Alexandro Castillo, Alex Castillo, Alejandro Rosales, Alejandro Castillo, Alejandro Rosales-Castillo, Alejandro Rosalescastillo",
                    Hair="Black", Eyes="Brown", Height="5'6''", Nationality="American", Gender="Male", Age=23, Race="",
                    CAUTION="Alejandro Rosales Castillo is wanted for his alleged involvement in the murder of a co-worker in Charlotte, North Carolina, in 2016. The female victim’s vehicle was located at a bus station in Phoenix, Arizona, on August 15, 2016. On August 17, 2016, the victim’s body was located in a wooded area in Cabarrus County, North Carolina, with a gunshot wound to the head.", REMARKS="Castillo's last known residence was in Charlotte, North Carolina. He has ties to Phoenix, Arizona. Castillo was seen crossing into Mexico and may reside in San Francisco de los Romo, Aguascalientes, or Pabellón de Arteaga, Aguascalientes. He also may have traveled to the Mexican states of Guanajuato or Veracruz.", REWARD="The FBI is offering a reward of up to $100,000 for information leading directly to the arrest of Alejandro Rosales Castillo.",
                    Picture="https://www.fbi.gov/wanted/topten/alejandro-castillo/@@images/image/preview"
                },

                new SuspectModel
                { 
                    Id = Guid.NewGuid().ToString(), Name = "ARNOLDO", Surname="JIMENEZ", Aliases="Arnoldo Gimenez, Arnoldo Rochel Jimenez",
                    Hair="Black", Eyes="Brown", Height="6'0''", Nationality="American", Gender="Male", Age=23, Race="",
                    CAUTION="Arnoldo Jimenez is wanted for allegedly killing his wife on May 12, 2012, the day after their wedding. He allegedly stabbed his wife to death in his black, four-door, 2006 Maserati, then allegedly dragged her body into the bathroom tub of her apartment in Burbank, Illinois. Jimenez was charged with first degree murder by the Circuit Court of Cook County, Illinois, and a state warrant was issued for his arrest on May 15, 2012. A federal arrest warrant was issued by the United States District Court, Northern District of Illinois, Eastern Division, on May 17, 2012, after Jimenez was charged federally with unlawful flight to avoid prosecution.", REMARKS="Jimenez may have fled to Durango, Mexico, specifically in the area of Santiago Papasquiaro. He may also frequent Reynosa, Tamaulipas, Mexico. He has previously resided in Chicago, Illinois.", REWARD="The FBI is offering a reward of up to $100,000 for information leading to the arrest of Arnoldo Jimenez.",
                    Picture="https://www.fbi.gov/wanted/topten/arnoldo-jimenez/@@images/image/preview"
                },

                new SuspectModel
                {
                    Id = Guid.NewGuid().ToString(), Name = "JASON DEREK", Surname="BROWN", Aliases="Jason D. Brown, Derek Brown, Greg Johnson, Harline Johnson, Greg Harline Johnson, John Brown, Jay Brown",
                    Hair="Blond", Eyes="Green", Height="5'10''", Nationality="American", Gender="Male", Age=23, Race="",
                    CAUTION="Jason Derek Brown is wanted for murder and armed robbery in Phoenix, Arizona. During November of 2004, Brown allegedly shot and killed an armored car guard outside a movie theater and then fled with the money.", REMARKS="Brown speaks fluent French and has a master's degree in International Business. He is an avid golfer, snowboarder, skier, and dirt biker. Brown enjoys being the center of attention and has been known to frequent nightclubs where he enjoys showing off his high-priced vehicles, boats, and other toys. Brown was a member of The Church of Jesus Christ of Latter-Day Saints, and completed his Mormon mission near Paris, France.", REWARD="The FBI is offering a reward of up to $200,000 for information leading directly to the arrest of Jason Derek Brown.",
                    Picture="https://www.fbi.gov/wanted/topten/jason-derek-brown/@@images/image/preview"
                },

                new SuspectModel
                {
                    Id = Guid.NewGuid().ToString(), Name = "ALEXIS", Surname="FLORES", Aliases="Mario Flores, Mario Roberto Flores, Mario F. Roberto, Alex Contreras, Alesis Contreras",
                    Hair="Black", Eyes="Brown", Height="5'4''", Nationality="Honduran", Gender="Male", Age=23, Race="",
                    CAUTION="Alexis Flores is wanted for his alleged involvement in the kidnapping and murder of a five-year-old girl in Philadelphia, Pennsylvania. The girl was reported missing in late July of 2000, and was later found strangled to death in a nearby apartment in early August of 2000.", REMARKS="Flores has ties to Honduras.", REWARD="The FBI is offering a reward of up to $100,000 for information leading directly to the arrest of Alexis Flores.",
                    Picture="https://www.fbi.gov/wanted/topten/alexis-flores/@@images/image/preview"
                },

                new SuspectModel 
                {
                    Id = Guid.NewGuid().ToString(), Name = "EUGENE", Surname="PALMER", Aliases="Eugene K. Palmer, Eugene Kenneth Palmer, Eugene Kevin Palmer",
                    Hair="Gray - Balding", Eyes="Brown", Height="5'10''", Nationality="American", Gender="Male", Age=23, Race="",
                    CAUTION="Eugene Palmer is wanted for allegedly shooting and killing his daughter-in-law on September 24, 2012, in Stony Point, New York.  After a local arrest warrant was issued for Palmer in Rockland County and he was charged with murder, a federal arrest warrant was issued on June 10, 2013, by the United States Court for the Southern District of New York after Palmer was charged with unlawful flight to avoid prosecution.", REMARKS="Palmer is known to be interested in auto racing and is a car enthusiast.  He is also an experienced hunter and outdoorsman.", REWARD="The FBI is offering a reward of up to $100,000 for information leading to the arrest and conviction of Eugene Palmer.",
                    Picture="https://www.fbi.gov/wanted/topten/eugene-palmer/@@images/image/preview"
                },

                new SuspectModel
                {
                    Id = Guid.NewGuid().ToString(), Name = "MOHAMMED REZA", Surname="SABAHI", Aliases="",
                    Hair="Brown", Eyes="Brown", Height="5'8''", Nationality="Iranian", Gender="Male", Age=23, Race="",
                    CAUTION="Mohammed Reza Sabahi is wanted for his alleged involvement in criminal activities, including obtaining unauthorized access to computer systems, stealing proprietary data from those systems, and selling that stolen data to Iranian customers such as Iranian universities and the Iranian government.  Sabahi was a contractor for the Mabna Institute, a private government contractor based in the Islamic Republic of Iran that performed this work for the Iranian government, at the behest of the Islamic Revolutionary Guard Corps.  Victims of the scheme included approximately 144 universities in the United States, 176 foreign universities in 21 countries, five federal and state government agencies in the United States, 36 private companies in the United States, 11 foreign private companies, and two international non-governmental organizations.   On February 7, 2018, a grand jury sitting in the United States District Court for the Southern District of New York indicted Sabahi on computer intrusion, wire fraud, and aggravated identity theft charges, and a federal arrest warrant has been issued for his arrest.", REMARKS="Sabahi is known to speak Farsi and resides in Iran.", REWARD="",
                    Picture="https://www.fbi.gov/wanted/cyber/mohammed-reza-sabahi/@@images/image/preview"
                },

                new SuspectModel 
                {
                    Id = Guid.NewGuid().ToString(), Name = "BEHZAD", Surname="MOHAMMADZADEH", Aliases="Mrb3hz4d",
                    Hair="Black", Eyes="Brown", Height="", Nationality="American", Gender="Male", Age=23, Race="",
                    CAUTION="Behzad Mohammadzadeh and Marwan Abusrour are wanted for their alleged involvement in criminal activities to include defacing public websites around the world with pro-Iranian and pro-hacker messages.  Mohammadzadeh allegedly defaced more than 1100 websites around the world with pro-Iranian and pro-hacker messages, which he began no later than on or about September 4, 2018, and has continued through the present day.  He is also alleged to have transmitted computer code to approximately 51 websites hosted in the United States, and defaced those websites by replacing their content with pictures of the late General Soleimani against a background of the Iranian flag, along with the message, “Down with America.”  On September 3, 2020, a grand jury in the United States District Court, District of Massachusetts, indicted Mohammadzadeh and Abusrour, and federal arrest warrants were issued for them after they were charged with Conspiracy to Commit Intentional Damage to a Protected Computer and Intentional Damage to a Protected Computer.", REMARKS="", REWARD="",
                    Picture="https://www.fbi.gov/wanted/cyber/behzad-mohammadzadeh/@@images/image/preview"
                },

                new SuspectModel
                {
                    Id = Guid.NewGuid().ToString(), Name = "CESAR HUMBERTO", Surname="LOPEZ-LARIOS", Aliases="El Grenas de Stoners”, “Oso de Stoners",
                    Hair="Black", Eyes="Brown", Height="5'8''", Nationality="Salvadoran", Gender="Male", Age=23, Race="White (Hispanic)",
                    CAUTION="Cesar Humberto Lopez-Larios is wanted for his alleged involvement in the direction of MS-13 activity in the United States, Mexico, and El Salvador.  He is alleged to be among the most senior leaders of MS-13 worldwide.  Lopez-Larios has been charged with several terrorism offenses for his alleged role in ordering numerous acts of violence against civilians, law enforcement, and rival gang members, as well as drug distribution and extortion schemes worldwide.  A federal arrest warrant was issued for Lopez-Larios in the United States District Court, Eastern District of New York, on December 16, 2020, after he was charged with Conspiracy to Provide and Conceal Material Support and Resources to Terrorists, Conspiracy to Commit Acts of Terrorism Transcending National Boundaries, Conspiracy to Finance Terrorism, and Narco-Terrorism Conspiracy.", REMARKS="Lopez-Larios has ties to North Hollywood, California, Mexico, and El Salvador.", REWARD="The FBI is offering a reward of up to $10,000 for information leading to the arrest of Cesar Humberto Lopez-Larios. Additional reward money may be available.",
                    Picture="https://www.fbi.gov/wanted/cei/cesar-humberto-lopez-larios/@@images/image/preview"
                },

                new SuspectModel
                {
                    Id = Guid.NewGuid().ToString(), Name = "EVELIN", Surname="MARTINEZ", Aliases="Eyelin Martinez, Evelin Martinez-Perez, Evelyn Martinez, Mileny Gonzalez",
                    Hair="Black", Eyes="Brown", Height="5'2''", Nationality="American", Gender="Female", Age=23, Race="White (Hispanic)",
                    CAUTION="Evelin Martinez, a known gang member, is wanted for her alleged involvement in a murder and attempted murder in 2009.\n\nOn December 28, 2009, Martinez allegedly drove her boyfriend, Steven Aguilar-Medina, to a rival gang area in Los Angeles, California. Martinez then allegedly stopped her van, and Aguilar-Medina allegedly exited the vehicle and approached two individuals standing outside a home. Aguilar-Medina allegedly then shouted a gang term, then allegedly fired multiple shots at the two individuals, killing one.\n\nMartinez was charged with murder and attempted murder by the Superior Court of California, County of Los Angeles, and a state warrant was issued for her arrest on January 8, 2010. A federal arrest warrant was issued by the United States District Court, Central District of California, Los Angeles, California, on March 3, 2010, after Martinez was charged federally with unlawful flight to avoid prosecution.", REMARKS="Martinez may be residing in, and has ties to, Mexico.", REWARD="The FBI is offering a reward of up to $5,000 for information leading to the arrest of Evelin Martinez.",
                    Picture="https://www.fbi.gov/wanted/murders/evelin-martinez/@@images/image/preview"
                }
            };
        }

        private int CalcAge(string day, string month, string year)
        {
            DateTime current;
            DateTime dob;

            current = DateTime.Today;
            dob = DateTime.Parse(day + "/" + month + "/" + year);

            var age = current - dob;

            return 0;
        }

        public async Task<bool> AddSuspectAsync(SuspectModel suspect)
        {
            suspects.Add(suspect);

            return await Task.FromResult(true);
        }

        public async Task<SuspectModel> GetSuspectAsync(string id)
        {
            return await Task.FromResult(suspects.FirstOrDefault(s => s.Id == id));
        }

        public async Task<ObservableCollection<SuspectModel>> GetSuspectsAsync(bool forceRefresh = false)
        {
            return await Task.FromResult(suspects);
        }

        public async Task<bool> DeletesuspectAsync(string id)
        {
            var oldItem = suspects.Where((SuspectModel arg) => arg.Id == id).FirstOrDefault();
            suspects.Remove(oldItem);

            return await Task.FromResult(true);
        }

        public async Task<bool> UpdateSuspectAsync(SuspectModel suspect)
        {
            var oldItem = suspects.Where((SuspectModel arg) => arg.Id == suspect.Id).FirstOrDefault();
            suspects.Remove(oldItem);
            suspects.Add(suspect);

            return await Task.FromResult(true);
        }
    }
}