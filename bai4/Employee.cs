namespace bai4
{
    public abstract class Employee : Person
    {
        public string Department { get; set; }
        public double Salary { set; get; }
        public string DateHied { set; get; }

        public override string ToString()
        {
            return $"Name: {Name}, Phone: {Phone}, Address: {Address}, Email: {Email}, Department: {Department}, Salary: {Salary}, DateHied: {DateHied}";
        }

        public abstract double CalculBonus();
        public abstract void CalculateVacation();
    }
}