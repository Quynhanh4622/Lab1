using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Data.Common;
using System.Runtime.InteropServices;
using System.Text;

namespace baithi
{
    internal class Program
    { 
        public static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            var sanPhamCollection = new SanPhamCollection();
            while (true)
            {
                Console.WriteLine("----------------------------------");
                Console.WriteLine("1. Tạo mới sản phẩm.");
                Console.WriteLine("2. Hiển thị danh sách sản phẩm.");
                Console.WriteLine("3. Xóa sản phẩm.");
                Console.WriteLine("0. Thoát chương trình.");
                Console.WriteLine("----------------------------------");
                Console.WriteLine("Vui lòng nhập lựa chọn của bạn từ 0->3: ");
                int choice = Int32.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1: sanPhamCollection.TaoMoiSanPham();
                        break;
                    case 2: sanPhamCollection.HienThiDanhSachSanPham();
                        break;
                    case 3: sanPhamCollection.XoaSanPham();
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