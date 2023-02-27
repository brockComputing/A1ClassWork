using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OandX
{
    class Program
    {
        class Country
        {
            public string CountryName { get; set; }
            public string CurrencyName { get; set; }
            public double ExchangeRate { get; set; }

        }

        static void Main(string[] args)
        {
            List<Country> countrylist = new List<Country>();
            string choice = "";
            while (choice != "9")
            {
                DisplayMenu();
                choice = Console.ReadLine();
                if (choice == "1")
                {
                    AddCountry(countrylist);
                }
                if (choice == "2")
                {
                    DisplayCountries(countrylist);
                }
            }
        }

        private static void DisplayMenu()
        {
            throw new NotImplementedException();
        }

        private static void DisplayCountries(List<Country> countrylist)
        {

        }

        private static void AddCountry(List<Country> countrylist)
        {
            string cname, currencyName;
            double exRate;
        }
    }
}



