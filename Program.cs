using System;
using System.Diagnostics.CodeAnalysis;
using System.Security.AccessControl;

namespace testing
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("please give me your password");
                string passwort = Console.ReadLine();
                int a = passwort.Length; //declares the passwort lenght
                int check = 0;
                int numcheck = 0;
                Console.WriteLine(a + " is the lenght of the passwort");

                for (int i = 0; i < a; i++)
                {
                    char letter = passwort[i]; 
                    Console.WriteLine(letter);
                    if (char.IsLower(letter))
                    {
                        check++;    //everytime there is a lowercase in the passwort it adds 1 to check
                        Console.WriteLine(check + " is the amount of lowercase letters in the password");

                    }
                    if (char.IsDigit(letter))
                    {
                        numcheck++; //everytime there is a num in the passwort it adds 1 to numcheck
                        Console.WriteLine(numcheck + " is the amount of numbers in the password");
                    }
                }

                if (a >= 8 & check != 8 & numcheck != 0) //it checks if the lenght is above 8, if theres a upercase letter and if theres a num in the passwoirt
                {
                    Console.WriteLine("passwort is secure");
                    break;
                }
                else
                {
                    Console.WriteLine("not secure, please give me another passwort");
                }
                Console.Read();
            }

        }   
    }
}
