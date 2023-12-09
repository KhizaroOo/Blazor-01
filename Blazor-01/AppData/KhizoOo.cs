using System;
namespace Blazor_01.AppData
{
	public class KhizoOo
	{

		public KhizoOo() { }


        public string ID { get; set; }
        public string FullName { get; set; }
        public string ShortName { get; set; }
        public string NickName { get; set; }
        public string FullBio { get; set; }
        public string ShortBio { get; set; }
        public int Age { get; set; }
        public DateTime Birthdate { get; set; }
        public string AddressOne { get; set; }
        public string AddressTwo { get; set; }
        public string AddressThree { get; set; }
        public string PhoneNumberOne { get; set; }
        public string PhoneNumberTwo { get; set; }
        public string PhoneNumberThree { get; set; }
        public string Email { get; set; }
        public string Occupation { get; set; }
        public string Nationality { get; set; }
        
        public bool IsMarried { get; set; }
        public string BloodType { get; set; }
        public string HairColor { get; set; }
        public string EyeColor { get; set; }
        public double HeightInCm { get; set; }
        public double WeightInKg { get; set; }
        public string FavoriteColor { get; set; }
        public string FavoriteFood { get; set; }
        public string Hobbies { get; set; }
        public string LanguagesSpoken { get; set; }
        public string ReligiousBeliefs { get; set; }
        public string PoliticalViews { get; set; }

        public SocialProfile MySocialProfile { get; set; }

        #region COMMON METHODS

        public int GetAge()
        {
            int years = DateTime.Now.Year - Birthdate.Year;
            if (DateTime.Now.DayOfYear < Birthdate.DayOfYear)
                years--;
            return years;
        }

        #endregion


    }

    public class SocialProfile
    {
        #region SOCIAL

        public string Facebook { get; set; }
        public string Instagram { get; set; }
        public string LinkedIn { get; set; }
        public string OpenSea { get; set; }
        public string Skype { get; set; }
        public string Snapchat { get; set; }
        public string TikTok { get; set; }
        public string Twitter { get; set; }
        public string YouTube { get; set; }
        public string Pinterest { get; set; }

        #endregion
    }

    public class KhizoOoImages
    {
        public string Title { get; set; }
        public string URL { get; set; }
        public string RouteLink { get; set; }
    }


}

