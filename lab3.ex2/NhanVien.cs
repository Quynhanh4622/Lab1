using System;
using System.Text;

namespace lab3.ex2
{
        public class NhanVien
        {
            public String FirstName { get; set; }
            public String LastName { get; set; }
            public String Address { get; set; }
            public long Sin { get; set; }
            public double Salary { get; set; }
        
            public void ToString()
            {
                Console.WriteLine($"Full Name: {FirstName}  {LastName}, Address: {Address}, Sin: {Sin}, Salary: {Salary}");
            }
            public void TienLuong(double percentage)
            {
                Console.OutputEncoding = Encoding.UTF8;
                Console.WriteLine($"Tien Luong: {this.Salary * percentage / 100}");
            
            }
        }
}