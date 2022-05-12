﻿using System;
using System.IO;

namespace Shoppinglist
{
    class Program
    {
        static void Main(string[] args)
        {
            string rootDirectory = @"C:\Users\veron\samples";
            Console.WriteLine("Enter directory name:");
            string newDirectory = Console.ReadLine();
            Console.WriteLine("Enter file name:");
            string fileName = Console.ReadLine();

            Directory.CreateDirectory($"{rootDirectory}\\{newDirectory}");


            if (Directory.Exists($"{rootDirectory}\\{newDirectory}") && File.Exists($"{ rootDirectory}\\{ newDirectory}\\{ fileName}"))
            {
                Console.WriteLine($"Directory and file exist.");

            }

            else
            {
                Directory.CreateDirectory($"{rootDirectory}\\{newDirectory}");
                File.Create($"{ rootDirectory}\\{ newDirectory}\\{ fileName}");
            }
        }
    }
}