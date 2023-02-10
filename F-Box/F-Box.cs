﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OandX
{
    class Program
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
                if (choice == "2")
                {
                    CharCount();
                }
            }







        }

        private static void CharCount()
        {
            string currentLine;
            int count = 0;
            char theCharTolookfor = ' ';
            Console.WriteLine("Enter the char to count in the file");
            theCharTolookfor = Convert.ToChar(Console.ReadLine());

            StreamReader currentFile = new StreamReader("film.txt");
            while (!currentFile.EndOfStream)
            {
                currentLine = currentFile.ReadLine();
                for (int i = 0; i < currentLine.Length; i++)
                {
                    if (theCharTolookfor == currentLine[i])
                    {
                        count++;
                    }
                }
            }
            Console.WriteLine($"{theCharTolookfor} occurs {count} times ");
            currentFile.Close();
            Console.ReadLine();
        }

        private static void DisplayFile()
        {
            string currentLine;
            StreamReader currentFile = new StreamReader("film.txt");
            while (!currentFile.EndOfStream)
            {
                currentLine = currentFile.ReadLine();
                Console.WriteLine(currentLine);
            }
            currentFile.Close();
            Console.ReadLine();
        }

        private static void DisplayMenu()
        {
            Console.WriteLine("1. to display file");
            Console.WriteLine("2. to char count");
            Console.WriteLine("3. to encrypt");
            Console.WriteLine("4. to decrypy");
        }
    }
}



