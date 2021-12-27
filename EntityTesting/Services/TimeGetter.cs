using System;
using System.Globalization;
using Microsoft.VisualBasic;

namespace EntityTesting.Services
{
    public interface ITime
    {
        public string Dt { get; set; }
        string GetTime();
    }

    public class TimeGetterUs : ITime
    {
        public string Dt { get; set; }

        public TimeGetterUs()
        {
            Dt = GetTime();
        }

        public string GetTime()
        {
            return DateTime.Now.ToString(CultureInfo.InvariantCulture) + " US";
        }
    }

    public class TimeGetterNl : ITime
    {
        public string Dt { get; set; }

        public TimeGetterNl()
        {
            Dt = GetTime();
            // Console.WriteLine("im in TimeGetterNL, personProvider.Born = " + personProvider.Born);
        }


        public string GetTime()
        {
            return DateTime.Now.ToString(CultureInfo.InvariantCulture) + " NL";
        }
    }
}