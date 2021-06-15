using System;

namespace lab5.ex1.order
{
    public class Grocery
    {
        public void orderGrocery()
        {
            Customer customer = new Customer();
            customer.getName();
            Console.WriteLine($"{customer.Name}");
            Console.WriteLine("Bạn đã chọn tạp hóa.");
        }
    }
}