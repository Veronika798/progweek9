using System;
using System.Collections.Generic;

namespace WishList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> myWishList = new List<string>();

            Console.WriteLine(myWishList.Count);

            myWishList.Add("coffee machine");
            myWishList.Add("pair of socks");
            myWishList.Add("bunjy jump ticket");
            myWishList.Add("new bed");

            Console.WriteLine(myWishList.Count);

            Console.WriteLine(myWishList[0]);
            Console.WriteLine(myWishList[1]);
            Console.WriteLine(myWishList[2]);

            foreach(string wish in myWishList)
            {
                Console.WriteLine(wish);
            }
        }
    }
}
