using System;
using System.Text;

namespace Ex2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Vui lòng nhập số nguyên: ");
            Console.WriteLine("Nhập a: ");
            var a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nhập b: ");
            var b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nhập c: ");
            var c = Convert.ToInt32(Console.ReadLine());
            if (a>b && a>c)
            {
                Console.WriteLine("a là số lớn nhất.");
            }
            if (b>a && b>c)
            {
                Console.WriteLine("b là số lớn nhất.");
            }

            if (c > a && c > b)
            {
                Console.WriteLine("c là số lớn nhất.");
            }
        }
    }
}