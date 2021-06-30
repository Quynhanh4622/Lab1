using System;
using System.Collections.Generic;

namespace baithi
{
    public class SanPhamCollection
    {
        private Dictionary<string, SanPham> _sanPhams = new Dictionary<string, SanPham>();

        public void TaoMoiSanPham()
        {
            var sanPham = new SanPham();
            Console.WriteLine("Vui lòng nhập id: ");
            var id = Console.ReadLine();
            Console.WriteLine("Vui lòng nhập tên sản phẩm: ");
            var name = Console.ReadLine();
            Console.WriteLine("Vui lòng nhập giá tiền sản phẩm: ");
            var price = double.Parse(Console.ReadLine());
            _sanPhams.Add(id,new SanPham()
            {
                Name = name,
                Price = price
            });
        }

        public void HienThiDanhSachSanPham()
        {
            Console.WriteLine("Id\t\tName\t\tPrice");
            foreach (var list in _sanPhams)
            {
                Console.WriteLine(list.ToString());
            }
        }

        public void XoaSanPham()
        {
            Console.WriteLine("Vui lòng nhập id: ");
            var id = Console.ReadLine();
            if (_sanPhams.ContainsKey(id))
            {
                _sanPhams.Remove(id);
                Console.WriteLine("Xóa thông tin thành công.");
            }
            else
            {
                Console.WriteLine("Sản phẩm không tồn tại!");
            }
        }
    }
}