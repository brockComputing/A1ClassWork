using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace isbn13Checkdigit
{
    class Program
    {
        static void Main(string[] args)
        {
            string anotherGO = "Y";
            string theBarCode = "";
            string choice = "";
            while (anotherGO.ToUpper() == "Y")
            {
                theBarCode = GetCode();
                Console.WriteLine("1. to add a check digit to the number ");
                Console.WriteLine("2. to check if a number is valid (check digit is included) ");
                choice = Console.ReadLine();
                if (choice == "1")
                {
                    theBarCode = theBarCode + CalcCheckdigit(theBarCode);
                    Console.WriteLine("The code with the digit added is " + theBarCode);
                }
                else
                {
                    if (ValidCode(theBarCode))
                    {
                        Console.WriteLine("the code enterd is VALID");
                    }
                    else
                    {
                        Console.WriteLine("the code enterd is INVALID");
                    }
                }
                Console.WriteLine("Another go? (y/n)");
                anotherGO = Console.ReadLine();
            }
        }

        private static bool ValidCode(string theBarCode)
        {

            string lastChar = theBarCode.Substring(theBarCode.Length - 1, 1);
            string tempBarCode = theBarCode.Substring(0, theBarCode.Length - 1);
            // get the last digit from theBarCode
            // create a string called tempBarCode from the theBarCode that does not have the last digit (use substring)
            // calculate the check digit for tempBarCode 
            // compare the check digits and return true if the same otherwise false
            if (CalcCheckdigit(tempBarCode).ToString() == lastChar)
            {
                return true;
            }
            return false;
        }

        private static int CalcCheckdigit(string theBarCode)
        {
            int oneORThree = 1;
            int chkDigit = 0;
            int total = 0, digit = 0;
            // add your code here
            for (int i = 0; i < theBarCode.Length; i++)
            {
                digit = Convert.ToInt32(theBarCode[i].ToString());
                total = total + digit * oneORThree;
                //oneORThree = (oneORThree == 1) ? 3 : 1;
                if (oneORThree == 1)
                {
                    oneORThree = 3;
                }
                else
                {
                    oneORThree = 1;
                }
            }
            chkDigit = total % 10;
            if (chkDigit == 0)
            {
                chkDigit = 0;
            }
            else
            {
                chkDigit = 10 - chkDigit;
            }
            return chkDigit;
        }
        private static string GetCode()
        {
            Console.Write("Enter the bar code ");
            return Console.ReadLine();
        }
    }
}
