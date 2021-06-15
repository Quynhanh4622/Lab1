using System;

namespace lab5.ex1.order
{
    public class Bread
    {
        public void orderBread()
        {
            Customer customer = new Customer();
            customer.getName();
            Console.WriteLine($"{customer.Name}");
            Console.WriteLine("Bạn đã chọn bánh mì.");
        }
    }
}