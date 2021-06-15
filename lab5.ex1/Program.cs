using System;
using System.Text;
using lab5.ex1.order;

namespace lab5.ex1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Bread bread = new Bread();
            Grocery grocery = new Grocery();
            while (true)
            {
                Console.WriteLine("Vui lòng nhập lựa chọn của bạn: ");
                Console.WriteLine("----------------------------------");
                Console.WriteLine("1: Hàng Tạp Hóa");
                Console.WriteLine("2: Bánh Mì");
                Console.WriteLine("3: Thoát Chương Trình.");
                Console.WriteLine("----------------------------------");
                int choice = Int32.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        grocery.orderGrocery();
                        break;
                    case 2:
                        bread.orderBread();
                        break;
                    case 3 : Console.WriteLine("Tạm biệt!");
                        break;
                    default: Console.WriteLine("Nhập sai, vui lòng nhập lại lưạ chọn của bạn từ 1->3");
                        break;
                }

                //Console.ReadLine();
                if (choice == 3)
                {
                    break;
                }
            }

        }
    }
}