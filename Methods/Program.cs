﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Add();
            //Add();
            //Add();
            //Add();
            //var result = Add2();

            int number1 = 20;
            int number2 = 100;
            var result2 = Add3(ref number1, number2);
            //Console.WriteLine(result);
            Console.WriteLine(result2);
            Console.WriteLine(number1);
            Console.ReadLine();
        }

        //Metotlar
        static void Add()
        {
            Console.WriteLine("Added!!!");
        }
        //Parametreli Metot
        //Default parametreli metot
        static int Add2(int number1 = 20, int number2 = 30)
        {
            var result = number1 + number2;
            return result;
        }
        //ref keyword kullanımı
        static int Add3(ref int number1, int number2)
        {
            number1 = 30;
            return number1 + number2;
        }
    }
}
