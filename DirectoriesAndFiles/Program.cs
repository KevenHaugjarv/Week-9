using System;
using System.IO;

namespace DirectoriesAndFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            string rootDirectory = @"C:\Users\...\Desktop\Kool\III aasta\Kevad\Programeerimine\N8 failid\Nädal 8 - failid-20220418";
            
            string newDirectory = @"wishList";

            Directory.CreateDirectory($"{rootDirectory}\\{newDirectory}");
        }
    }
}
