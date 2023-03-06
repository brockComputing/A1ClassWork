using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.IO;

namespace Sorting_Assignment_done
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
            Console.WriteLine("enter a country name ");
            string countryName = Console.ReadLine();
            foreach (var item in countrylist)
            {
                if (countryName == item.CountryName)
                {
                    Console.WriteLine($"The exchange rate is {item.ExchangeRate}" );
                }
            }
        }

        private static void DisplayCountries(List<Country> countrylist)
        {
            foreach (var item in countrylist)
            {
                Console.WriteLine($"{item.CountryName}  {item.CurrencyName}  {item.ExchangeRate}");
            }
        }

        private static void AddCountry(List<Country> countrylist)
        {
            Console.WriteLine("Enter the country name");
            string countryName = Console.ReadLine();
            Console.WriteLine("Enter the currency name:");
            string currencyName = Console.ReadLine();
            Console.WriteLine("Enter the exchange rate");
            double exchangeRate = Convert.ToDouble(Console.ReadLine());
            Country aCountry = new Country();
            aCountry.CountryName = countryName; 
            aCountry.CurrencyName = currencyName;
            aCountry.ExchangeRate = exchangeRate;
            countrylist.Add(aCountry);
            //countrylist.Add(new Country {CountryName = countryName, CurrencyName = currencyName, ExchangeRate = exchangeRate}); 
        }

        private static void DisplayMenu()
        {
            Console.WriteLine("1. Add country");
            Console.WriteLine("2. Display all countrys");
            Console.WriteLine("3. Find a countries exchange rate");
        }
    }
}



