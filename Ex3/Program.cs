using System;
using System.Text;

namespace Ex3
{
    internal class Program
    {
        public static void Main(string[] args)
        {
                   Console.OutputEncoding = Encoding.UTF8;
                   int s1;
                   Console.WriteLine("Vui lòng nhập từ 1 -> 7");
                   do
                   {
                       s1 = Convert.ToInt32(Console.ReadLine());
                       if (s1 == 1)
                       {
                           Console.WriteLine("Thứ Hai");
                       }
                       else if (s1 == 2)
        
                       {
                           Console.WriteLine("Thứ Ba");
                       }
                       else if (s1 == 3)
                       {
                           Console.WriteLine("Thứ Tư");
                       }
                       else if (s1 == 4)
                       {
                           Console.WriteLine("Thứ năm");
                       }
                       else if (s1 == 5)
                       {
                           Console.WriteLine("Thứ Sáu");
                       }
                       else if (s1 == 6)
                       {
                           Console.WriteLine("Thứ Bảy");
                       }
                       else if (s1 == 7)
                       {
                           Console.WriteLine("Chủ Nhật");
                       }
                   } while (s1 <= 7);
                   Console.ReadLine();
            
        }
    }
}