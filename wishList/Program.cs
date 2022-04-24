using System;
using System.Collections.Generic;

namespace wishList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> myWishList = new List<string>();

            Console.WriteLine(myWishList.Count);

            myWishList.Add("Kohvimasin");
            myWishList.Add("LCD televiisor");
            myWishList.Add("Ferrari");
            myWishList.Add("Coca Cola");

            Console.WriteLine(myWishList.Count);

            foreach(string wish in myWishList)
            {
                Console.WriteLine(wish);
            }


        }
    }
}
