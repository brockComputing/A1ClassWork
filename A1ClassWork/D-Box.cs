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
        static void Main(string[] args)
        {

            string choice = "";
            while (choice != "9")
            {
                DisplayMenu();
                choice = Console.ReadLine();
                if (choice == "1")
                {
                    DisplayFile();
                }
            }


        }

        private static void DisplayFile()
        {
            throw new NotImplementedException();
        }

        private static void DisplayMenu()
        {
            throw new NotImplementedException();
        }
    }
}
