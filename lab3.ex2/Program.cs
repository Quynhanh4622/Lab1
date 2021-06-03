using System;

namespace lab3.ex2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            NhanVien nhanVien = new NhanVien();
            Console.WriteLine("Please enter employee information: ");
            Console.WriteLine("First Name: ");
            nhanVien.FirstName = Console.ReadLine();
            Console.WriteLine("Last Name: ");
            nhanVien.LastName = Console.ReadLine();
            Console.WriteLine("Address: ");
            nhanVien.Address = Console.ReadLine();
            Console.WriteLine("Sin: ");
            nhanVien.Sin = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("Salary: ");
            nhanVien.Salary = Convert.ToDouble(Console.ReadLine());
            nhanVien.ToString();

            double a = double.Parse(Console.ReadLine());
            nhanVien.TienLuong(nhanVien.Salary);
        }
    }
}