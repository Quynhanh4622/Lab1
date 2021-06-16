namespace lab5.ex2
{
    public class HighSchoolTeacher: Person, IEmployeeAction
    {
        private IEmployeeAction _employeeActionImplementation;
        public string HighSchoolTeacherCode { get; set; }

        public double CalculateSalary()
        {
            return BaseSalary * SkillLevel + SeniorLecture + Bonus;

        }
    }
}