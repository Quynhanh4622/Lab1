using System;
using System.Text;

namespace lab5.ex2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Vui lòng nhập tên");
            var name = Console.ReadLine();
            Console.WriteLine("vui lòng nhập salary");
            var salary = double.Parse(Console.ReadLine());
            Console.WriteLine("vui lòng nhập bonus");
            var bonus = double.Parse(Console.ReadLine());
            var seniorLecture = new SeniorLecture
            {
                Name = name,
                Salary = salary,
                Bonus = bonus
            };
            try
            {
                CheckAmount(seniorLecture);
            }
            catch (AmountException e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public static void CheckAmount(SeniorLecture seniorLecture)
        {
            if (seniorLecture.Salary < 60000)
            {
                throw new AmountException($"mức lương của giảng viên {seniorLecture.Name} tối thiểu phải từ 60000");
            }
            else if(seniorLecture.Bonus > 10000)
            {
                throw new AmountException($"mức thưởng của giảng viên {seniorLecture.Name} tối đa không quá 10000");
            }
            else
            {
                Console.WriteLine("Ok");
            }

        }
    }
}