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
                if (choice == "3")
                {
                    EorD(1);
                }
                if (choice == "4")
                {
                    EorD(-1);
                }
                if (choice == "5")
                {
                    Vernam();
                }
            }







        }

        private static void Vernam()
        {
            string OTP = "sdfkljgfjdgfjodigjoerjia'gjjuhgdfkghdfsgklgflsdjkg;ljfg'sj'djg";
            string thefile = File.ReadAllText("film.txt");
            string newText ="";
            int count = 0;
            foreach (var item in thefile)
            {
                int asciiThefile = Convert.ToInt32(item);
                int asciiTheOTP =   Convert.ToInt32(OTP[count]);
                char newChar = Convert.ToChar(asciiThefile ^ asciiTheOTP);
                newText = newText + newChar;
            }
            File.WriteAllText("film.txt",newText);
        }

        private static void DecryptFile()
        {
            string currentline;
            StreamReader currentfile1 = new StreamReader("film.txt");
            StreamWriter currentfile2 = new StreamWriter("temp.txt");
            while (!currentfile1.EndOfStream)
            {
                string newString = "";
                string lineoftext = currentline = currentfile1.ReadLine();
                foreach (char x in lineoftext)
                {
                    int ascii = Convert.ToInt32(x);
                    ascii = ascii - 1;
                    char newchar = Convert.ToChar(ascii);
                    newString = newString + newchar;

                }
                currentfile2.WriteLine(newString);
            }
            currentfile2.Close();
            currentfile1.Close();
            File.Delete("film.txt");
            File.Move("temp.txt", "film.txt");
        }

        private static void EorD(int key)
        {
            string currentline;
            StreamReader currentfile1 = new StreamReader("film.txt");
            StreamWriter currentfile2 = new StreamWriter("temp.txt");
            while (!currentfile1.EndOfStream)
            {
                string newString = "";
                string lineoftext = currentline = currentfile1.ReadLine();
                foreach (char x in lineoftext)
                {
                    int ascii = Convert.ToInt32(x);
                    ascii = ascii + key;
                    char newchar = Convert.ToChar(ascii);
                    newString = newString + newchar;

                }
                currentfile2.WriteLine(newString);
            }
            currentfile2.Close();
            currentfile1.Close();
            File.Delete("film.txt");
            File.Move("temp.txt", "film.txt");

        }



        private static void EncryptFile()
        {
            string currentline;
            StreamReader currentfile1 = new StreamReader("film.txt");
            StreamWriter currentfile2 = new StreamWriter("temp.txt");
            while (!currentfile1.EndOfStream)
            {
                string newString = "";
                string lineoftext = currentline = currentfile1.ReadLine();
                foreach (char x in lineoftext)
                {
                    int ascii = Convert.ToInt32(x);
                    ascii = ascii + 1;
                    char newchar = Convert.ToChar(ascii);
                    newString = newString + newchar;

                }
                currentfile2.WriteLine(newString);
            }
            currentfile2.Close();
            currentfile1.Close();
            File.Delete("film.txt");
            File.Move("temp.txt", "film.txt");

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
            Console.WriteLine("5. Vernam ");
        }
    }
}



