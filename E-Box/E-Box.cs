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
                else if (choice == "2")
                {
                    CountChar();
                }
                else if (choice == "8")
                {
                    CountAllChars();
                }
            }


        }

        private static void CountAllChars()
        {
            for (int i = 65; i < 92; i++)
            {
                Console.WriteLine($"");
            }
        }

        static int CountChar(char letterToSeachfor)
        {
            int count = 0;
            string currentLine;
            StreamReader currentFile = new StreamReader("film.txt");
            while (!currentFile.EndOfStream)
            {
                currentLine = currentFile.ReadLine();
                for (int i = 0; i < currentLine.Length; i++)
                {
                    if (letterToSeachfor == currentLine[i])
                    {
                        count++;
                    }
                }
            }
            currentFile.Close();
            return count;
        }

        private static void CountChar()
        {
            Console.WriteLine("Enter a letter to search for");
            char letterToSeachfor = Convert.ToChar(Console.ReadLine());
            int count = 0;
            string currentLine;
            StreamReader currentFile = new StreamReader("film.txt");
            while (!currentFile.EndOfStream)
            {
                currentLine = currentFile.ReadLine();
                for (int i = 0; i < currentLine.Length; i++)
                {
                    if (letterToSeachfor == currentLine[i])
                    {
                        count++;
                    }
                }
            }
            Console.WriteLine($"{letterToSeachfor} occurs {count} times");
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
            Console.WriteLine("1. to display the file");
            Console.WriteLine("2. char count");
            Console.WriteLine("3. to encrypt the file");
            Console.WriteLine("4. to decrypt the file");
        }
    }
}



