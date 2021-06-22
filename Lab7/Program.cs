using System;
using System.Text;

namespace Lab7
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            var nhanVienManager = new NhanVienManager();
            while (true)
            {
                Console.WriteLine("---------------------------------------");
                Console.WriteLine("1. Tạo mới nhân viên.");
                Console.WriteLine("2. Hiển thị danh sách nhân viên.");
                Console.WriteLine("3. Sửa thông tịn nhân viên.");
                Console.WriteLine("4. Xóa thông tin nhân viên.");
                Console.WriteLine("0. Đóng chương trình.");
                Console.WriteLine("----------------------------------------");
                Console.WriteLine("Vui lòng nhập lựa chọn của bạn từ 0->4: ");
                var choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1: nhanVienManager.Create();
                        break;
                    case 2: nhanVienManager.Display();
                        break;
                    case 3: nhanVienManager.Update();
                        break;
                    case 4: nhanVienManager.Delete();
                        break;
                }

                if (choice == 0)
                {
                    break;
                }
            }
        }
    }
}