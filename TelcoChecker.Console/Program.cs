using System;
using System.Collections.Generic;
using TelcoChecker.Library.Model;
using TelcoChecker.Library.Services;

namespace TelcoChecker.Console
{

    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Enter phone number: ");
            string phoneNumber = System.Console.ReadLine();
            TelcoProvider provider = TelcoService.GetPhoneNumberTelco(phoneNumber);
            System.Console.WriteLine(provider.ToString());
            System.Console.ReadLine();
        }

        
    }
}
