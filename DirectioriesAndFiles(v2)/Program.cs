using System;
using System.IO;

namespace DirectioriesAndFiles_v2_
{
    class Program
    {
        static void Main(string[] args)
        {
            string rootDirectory = @"C:\Users\...\Desktop\Kool\III aasta\Kevad\Programeerimine\N8 failid\Nädal 8 - failid-20220418";
            Console.WriteLine("Sisesta kausta nimi");
            string newDirectory = Console.ReadLine();
            Console.WriteLine("Sisesta faili nimi");
            string fileName = Console.ReadLine();


            
            if (Directory.Exists($"{rootDirectory}\\{newDirectory}") && File.Exists($"{rootDirectory}\\{newDirectory}\\{fileName}")) 
            {
                Console.WriteLine($"Kaust ja fail on juba olemas");
            }
            else
            {
                Directory.CreateDirectory($"{rootDirectory}\\{newDirectory}");
                File.Create($"{rootDirectory}\\{newDirectory}\\{fileName}");
            }

        }
    }
}
