using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A1ClassWork
{
    internal class Program
    {
        class Country
        {
            public string CountryName { get; set; }
            public string CurrencyName { get; set; }
            public double ExchangeRate { get; set; }
        }
        
        static void Main(string[] args)
        {
            List<Country> countryList = new List<Country>();   
            string choice = "";
            while (choice != "9")
            {
                Console.WriteLine("1. Add a country");
                Console.WriteLine("2. Display all countries");
                choice = Console.ReadLine();
                if (choice == "1")
                {
                    AddCountry(countryList);
                }
                else if (choice == "2")
                {
                    DisplayCountries(countryList);
                }
            }
        }

        private static void DisplayCountries(List<Country> countryList)
        {
            foreach (var item in countryList)
            {
                Console.WriteLine($"{item.CountryName}   {item.CurrencyName} {item.ExchangeRate}");
            }
        }

        private static void AddCountry(List<Country> countryList)
        {
            string cName, currName;
            double exRate;
            Console.WriteLine("enter the country name");
            cName = Console.ReadLine();
            Console.WriteLine("enter the currency name");
            currName = Console.ReadLine();
            Console.WriteLine("enter the exchange rate");
            exRate = Convert.ToDouble(Console.ReadLine());
            countryList.Add(new Country { CountryName = cName, CurrencyName = currName , ExchangeRate = exRate});
        }
    }
}
