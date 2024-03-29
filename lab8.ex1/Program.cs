﻿using System;
using System.Collections.Generic;
using System.Text;

namespace lab8.ex1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            var temperatures = new List<int>();
            temperatures.Add(12);
            temperatures.Add(17);
            temperatures.Add(22);
            temperatures.Add(72);
            temperatures.Add(42);
            temperatures.Add(34);
            temperatures.Add(56);
            var count = 0;
            foreach (var temperature in temperatures)
            {
                if (temperature >= 25)
                {
                    count++;
                }
            }

            Console.WriteLine("Vui lòng nhập min cho GreaterCount");
            var min = int.Parse(Console.ReadLine());
            var result = GreaterCount(temperatures, min);
            Console.WriteLine($"Số lần nhiệt đọ vượt quá 25 độ là {count}");
            Console.WriteLine($"số lần nhiệt độ vượt quá {min} độ là {result}");
        }

        private static int GreaterCount(List<int> list, double min)
        {
            var count = 0;
            foreach (var item in list)
            {
                if (item >= min)
                {
                    count++;
                }
            }

            return count;
        }
    }
}