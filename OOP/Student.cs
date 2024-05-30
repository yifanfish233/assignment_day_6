namespace OOD;

public class Student : Person, IStudentService
{
    public List<string> Courses { get; set; }

    public Student(string name, DateTime birthDate) : base(name, birthDate)
    {
        Courses = new List<string>();
    }

    public override int CalculateAge(DateTime birthDate)
    {
        return DateTime.Now.Year - birthDate.Year;
    }

    public override decimal CalculateSalary(decimal baseSalary)
    {
        throw new NotImplementedException("Students do not have a salary");
    }

    public double CalculateGPA(List<string> grades)
    {
        // GPA calculation logic
        double totalPoints = 0;
        foreach (var grade in grades)
        {
            switch (grade)
            {
                case "A": totalPoints += 4.0; break;
                case "B": totalPoints += 3.0; break;
                case "C": totalPoints += 2.0; break;
                case "D": totalPoints += 1.0; break;
                case "F": totalPoints += 0; break;
            }
        }
        return totalPoints / grades.Count;
    }
}