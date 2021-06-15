using System;

namespace lab5.ex1
{
    public class Customer
    {
        public string Name { get; set; }

        public void getName()
        {
            Console.WriteLine("Vui lòng nhập họ tên đầy đủ: ");
            Name = Console.ReadLine();
        }
    }
}