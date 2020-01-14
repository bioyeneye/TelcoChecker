using System.Collections.Generic;
using TelcoChecker.Library.Model;

namespace TelcoChecker.Library.Services
{
    public class TelcoService
    {
        private static List<string> mtn = new List<string>
            {
                "0803", "0816", "0903", "0810", "0806", "0703", "0701", "0813", "0814", "0906"
            };

        private static List<string> airtel = new List<string>
            {
                "0907", "0708", "0802", "0902", "0812", "0808", "0701"
            };

        private static List<string> glo = new List<string>
            {
                "0805", "0905", "0807", "0811", "0705", "0815"
            };

        private static List<string> etisalat = new List<string>
            {
                "0909", "0908", "0818", "0809", "0817"
            };

        public static TelcoProvider GetPhoneNumberTelco(string phoneNumber)
        {
            if (phoneNumber == null || phoneNumber.Length < 11)
            {
                return TelcoProvider.NON;
            }

            var firstFour = phoneNumber.Substring(0, 4);
            if (mtn.Contains(firstFour))
            {
                return TelcoProvider.MTN;
            }

            if (airtel.Contains(firstFour))
            {
                return TelcoProvider.AIRTEL;
            }

            if (glo.Contains(firstFour))
            {
                return TelcoProvider.GLO;
            }

            if (etisalat.Contains(firstFour))
            {
                return TelcoProvider.ETISALAT;
            }

            return TelcoProvider.NON;
        }

        public static string FormartPhoneNumber(string phonenumber, Country country = Country.NIGERIA)
        {
            return string.Empty;
        }
    }
}
