using System;
using System.Text;

namespace lab5.ex2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            HighSchoolTeacher highSchoolTeacher = new HighSchoolTeacher
            {
                IdentityNumber = "ID001",
                FullName = "anh",
                BaseSalary = 100,
                SkillLevel = 1,
                SeniorLecture = 600000,
                Bonus = 10000,
                HighSchoolTeacherCode = "teach001"
                
            };
            Console.WriteLine(highSchoolTeacher.CalculateSalary());
            UniversityTeacher universityTeacher = new UniversityTeacher
            {
                IdentityNumber = "ID002",
                FullName = "anh duong",
                BaseSalary = 200,
                SkillLevel = 2,
                SeniorLecture = 700000,
                Bonus = 10000,
                UniversityTeacherCode = "university_teach001"
            };
            Console.WriteLine(universityTeacher.CalculateSalary());
        }
    }
}