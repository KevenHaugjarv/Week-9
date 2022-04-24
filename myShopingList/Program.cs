using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace myList
{
    class Program
    {
        static void Main(string[] args)
        {
            string fileLocation = @"C:\Users\...\Desktop\Kool\III aasta\Kevad\Programeerimine\N9";
            string fileName = @"\\myShopingList.txt";
            string[] arrayFromFile = File.ReadAllLines($"{fileLocation}{fileName}");

            List<string> myShopingList = arrayFromFile.ToList<string>();
            bool loopActive = true;

            while (loopActive)
            {
                Console.WriteLine("Kas soovid luua ostunimekirja? Y/N:");
                char userInput = Convert.ToChar(Console.ReadLine().ToLower());

                if (userInput == 'y')
                {
                    Console.WriteLine("Sisesta tooted");
                    string userShopingList = Console.ReadLine();
                    myShopingList.Add(userShopingList);
                }

                else
                {
                    loopActive = false;
                    Console.WriteLine("Head aega!");
                }

            }
            Console.Clear();

            foreach (string List in myShopingList)
            {
                Console.WriteLine($"Sinu nimekiri: {List}");
            }

            File.WriteAllLines($"{fileLocation}{fileName}", myShopingList);
        }
    }
}
