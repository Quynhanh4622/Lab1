using System;
using System.Text;
using Ex1.entity;
namespace Ex1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("vui lòng nhập thông tin:");
            SinhVien sinhVien = new SinhVien();
            Console.WriteLine("Nhập tên: ");
            sinhVien.Name = Console.ReadLine();
            Console.WriteLine("Nhập địa chỉ: ");
            sinhVien.Address = Console.ReadLine();
            Console.WriteLine("Nhập số điện thoại: ");
            sinhVien.Phone = Console.ReadLine();
        }
    }
}