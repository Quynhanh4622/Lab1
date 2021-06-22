using Microsoft.SqlServer.Server;

namespace Lab7
{
    public class NhanVien
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public double Salary { get; set; }

        public override string ToString()
        {
            return $"Tên : {Name}, Tuổi : {Age}, Lương : {Salary}";
        }
    }
}