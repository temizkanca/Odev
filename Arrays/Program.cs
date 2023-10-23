﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class Program
    {
        //Diziler
        static void Main(string[] args)
        {
            string[] students = new string[3] { "Engin", "Derin", "Salih" };

            string[] students2 = { "Engin", "Derin", "Salih" };
            //students2[3] = "Ahmet";

            //foreach (var student in students2)
            //{
            //    Console.WriteLine(student);
            //}

            //Çok boyutlu diziler
            string[,] regions = new string[5, 3]
            {
                {"İstanbul","İzmit","Balıkesir"},
                {"Ankara","Konya","Kırıkkale"},
                {"Antalya","Adana","Mersin"},
                {"Rize","Trabzon","Samsun"},
                {"İzmir","Muğla","Manisa"},
            };
            //GetUpperBound en üst değeri alır.
            for (int i = 0; i <= regions.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= regions.GetUpperBound(1); j++)
                {
                    Console.WriteLine(regions[i,j]);
                }
                Console.WriteLine("*********");
            }

            Console.ReadLine();
        }
    }
}
