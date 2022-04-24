using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace MyWishListFile
{
    class Program
    {
        public static bool Wish { get; private set; }

        static void Main(string[] args)
        {
            string fileLocation = @"C:\Users\...\Desktop\Kool\III aasta\Kevad\Programeerimine\N8 failid\Nädal 8 - failid-20220418\wishList";
            string fileName = @"\\myWishList.txt";
            string[] arrayFromFile = File.ReadAllLines($"{fileLocation}{fileName}");

            List<string> myWishList = arrayFromFile.ToList<string>();
            bool loopActive = true;

            while (loopActive)
            {
                Console.WriteLine("would you like to add a wish? Y/N:");
                char userInput = Convert.ToChar(Console.ReadLine().ToLower());
                
                if(userInput == 'y')
                {
                    Console.WriteLine("Enter you wish");
                    string userwish = Console.ReadLine();
                    myWishList.Add(userwish);
                }

                else
                {
                    loopActive = false;
                    Console.WriteLine("Head aega!");
                }

            }
            Console.Clear();

            foreach(string wish in myWishList)
            {
                Console.WriteLine($"your wish: {wish}");
            }

            File.WriteAllLines($"{fileLocation}{fileName}", myWishList);
        }
    }
}
