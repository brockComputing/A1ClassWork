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
                if (choice == "3")
                {
                    FindExchangeRate(countrylist);
                }
            }
        }

        private static void FindExchangeRate(List<Country> countrylist)
        {
            // get country name from user
            Console.WriteLine("Enter a country name");
            string cname = Console.ReadLine();
            foreach (var item in countrylist)
            {
                if (item.CountryName == cname)
                {
                    Console.WriteLine($"the exchange rate is {item.ExchangeRate}");
                }
            }
            // loop through countryList and find the country that matches the user entered
            // output the exchange rate.
        }

        private static void DisplayMenu()
        {
            Console.WriteLine("1. Add country");
            Console.WriteLine("2. Display all countrys");
            Console.WriteLine("3. Find a countries exchange rate");
        }

        private static void DisplayCountries(List<Country> countrylist)
        {
            foreach (var item in countrylist)
            {
                Console.WriteLine($"{item.CountryName}   {item.CurrencyName}   {item.ExchangeRate}");
            }
        }

        private static void AddCountry(List<Country> countrylist)
        {
            string cname, currencyName;
            double exRate;
            Console.WriteLine("Enter the country name");
            cname = Console.ReadLine();
            Console.WriteLine("Enter the currency name");
            currencyName = Console.ReadLine();
            Console.WriteLine("Enter the exchange rate");
            exRate = Convert.ToDouble(Console.ReadLine());
            // or
            Country aCountry = new Country();
            aCountry.CountryName = cname;
            aCountry.CurrencyName = currencyName;
            aCountry.ExchangeRate = exRate;
            countrylist.Add(aCountry);
            // or
            //countrylist.Add(new Country() { CountryName = cname, CurrencyName = currencyName, ExchangeRate = exRate });



        }
    }
}



