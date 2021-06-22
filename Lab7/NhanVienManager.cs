using System;
using System.Collections.Generic;

namespace Lab7
{
    public class NhanVienManager
    {
        private Dictionary<string, NhanVien> _nhanViens = new Dictionary<string, NhanVien>();
        public void Create()
        {
            Console.WriteLine("Vui lòng nhập id: ");
            var id = Console.ReadLine();
            Console.WriteLine("Vui lòng nhập tên: ");
            var name = Console.ReadLine();
            Console.WriteLine("Vui lòng nhập tuổi: ");
            var age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Vui lòng nhập lương: ");
            var salary = double.Parse(Console.ReadLine());
            _nhanViens.Add(id,new NhanVien()
            {
                Name = name,
                Age = age,
                Salary = salary
            });
        }
        public void Display ()
        {
            foreach (var list in _nhanViens)
            {
                Console.WriteLine($"id: {list.Key},{list.Value}");
            }
        }

        public void Update()
        {
            Console.WriteLine("Vui lòng nhập id: ");
            var id = Console.ReadLine();
            if (_nhanViens.ContainsKey(id))
            {
                Console.WriteLine("Vui lòng sửa tên: ");
                var name = Console.ReadLine();
                Console.WriteLine("Vui lòng sửa tuổi: ");
                var age = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Vui lòng sửa lương: ");
                var salary = double.Parse(Console.ReadLine());
                _nhanViens[id].Name = name;
                _nhanViens[id].Age = age;
                _nhanViens[id].Salary = salary;
            }
            else
            {
                Console.WriteLine("Nhân viên không tồn tại!");
            }
        }

        public void Delete()
        {
            Console.WriteLine("Vui lòng nhập id: ");
            var id = Console.ReadLine();
            if (_nhanViens.ContainsKey(id))
            {
                _nhanViens.Remove(id);
                Console.WriteLine("Xóa thông tin thành công.");
            }
            else
            {
                Console.WriteLine("Nhân viên không tồn tại!");
            }
        }
    }
}