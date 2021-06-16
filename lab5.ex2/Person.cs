using System;

namespace lab5.ex2
{
    public abstract class Person
    {
        public string IdentityNumber { get; set; }
        public string FullName { get; set; }
        public double BaseSalary { get; set; }//luong co ban
        public int SkillLevel { get; set; }//dung de tinh thong tin luong
        public double SeniorLecture { get; set; }//cong them vao luong
        public double Bonus { get; set; }//cong them vao luong
    }
}