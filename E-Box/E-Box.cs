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
        class Student
        {
            public string FirstName { get; set; }
            public string SurName { get; set; }
            public bool DepositPaid { get; set; }
            public DateTime Dob { get; set; }
        }


        static void Main(string[] args)
        {
            List<Student> studentList = new List<Student>();





            Student s1  = new Student();
            s1.SurName = "jones";
            s1.FirstName = "Bryn";
            studentList.Add(s1);
            Student s2 = new Student();
            s2.SurName = "smith";
            studentList.Add(s2);
            studentList.Add(new Student { SurName = "Davis", DepositPaid = true });
            foreach (var item in studentList)
            {
                Console.WriteLine($"surname {item.SurName}");
            }
            for (int i = 0; i < studentList.Count; i++)
            {
                Console.WriteLine($"Surname {studentList[i].SurName}");
            }

           

            
            Console.ReadLine();
        }

        private static void Vernam()
        {
            string OTP = "sdfkljgfjdgfjodigjoerjia'gjjuhgdfkghdfsgklgflsdjkg;ljfg'sj'djg";
            string thefile = File.ReadAllText("film.txt");
            string newText = "";
            int count = 0;
            foreach (var item in thefile)
            {
                int asciiThefile = Convert.ToInt32(item);
                int asciiTheOTP = Convert.ToInt32(OTP[count]);
                char newChar = Convert.ToChar(asciiThefile ^ asciiTheOTP);
                newText = newText + newChar;
            }
            File.WriteAllText("film.txt", newText);
        }

        static void EorD(int key)
        {
            string currentline;
            StreamReader filmFile = new StreamReader("film.txt");
            StreamWriter tempFile = new StreamWriter("temp.txt");
            while (!filmFile.EndOfStream)
            {
                string newString = "";
                string lineoftext = currentline = filmFile.ReadLine();
                foreach (char theLetter in lineoftext)
                {
                    int ascii = Convert.ToInt32(theLetter);
                    ascii = ascii + key;
                    char newchar = Convert.ToChar(ascii);
                    newString = newString + newchar;

                }
                tempFile.WriteLine(newString);
            }
            tempFile.Close();
            filmFile.Close();
            File.Delete("film.txt");
            File.Move("temp.txt", "film.txt");
        }
        private static void Decrypt()
        {
            string currentline;
            StreamReader filmFile = new StreamReader("film.txt");
            StreamWriter tempFile = new StreamWriter("temp.txt");
            while (!filmFile.EndOfStream)
            {
                string newString = "";
                string lineoftext = currentline = filmFile.ReadLine();
                foreach (char theLetter in lineoftext)
                {
                    int ascii = Convert.ToInt32(theLetter);
                    ascii = ascii - 1;
                    char newchar = Convert.ToChar(ascii);
                    newString = newString + newchar;

                }
                tempFile.WriteLine(newString);
            }
            tempFile.Close();
            filmFile.Close();
            File.Delete("film.txt");
            File.Move("temp.txt", "film.txt");
        }

        private static void Encrypt()
        {
            string currentline;
            StreamReader filmFile = new StreamReader("film.txt");
            StreamWriter tempFile = new StreamWriter("temp.txt");
            while (!filmFile.EndOfStream)
            {
                string newString = "";
                string lineoftext = currentline = filmFile.ReadLine();
                foreach (char theLetter in lineoftext)
                {
                    int ascii = Convert.ToInt32(theLetter);
                    ascii = ascii + 1;
                    char newchar = Convert.ToChar(ascii);
                    newString = newString + newchar;

                }
                tempFile.WriteLine(newString);
            }
            tempFile.Close();
            filmFile.Close();
            File.Delete("film.txt");
            File.Move("temp.txt", "film.txt");
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

        }

        private static void DisplayMenu()
        {
            Console.WriteLine("1. to display the file");
            Console.WriteLine("2. char count");
            Console.WriteLine("3. to encrypt the file");
            Console.WriteLine("4. to decrypt the file");
            Console.WriteLine("5. Vernam");
        }
    }
}



