﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    internal class Program
    {
        //Döngüler
        static void Main(string[] args)
        {
            for (int i = 1; i <= 100; i=i+2)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("Finished");

            Console.ReadLine();
        }
    }
}