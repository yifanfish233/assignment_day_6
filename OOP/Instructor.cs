namespace OOD;

public class Instructor : Person, IInstructorService
{
    public string Department { get; set; }
    public bool IsHeadOfDepartment { get; set; }
    public DateTime JoinDate { get; set; }

    public Instructor(string name, DateTime birthDate, string department, DateTime joinDate) : base(name, birthDate)
    {
        Department = department;
        JoinDate = joinDate;
        IsHeadOfDepartment = false;
    }

    public override int CalculateAge(DateTime birthDate)
    {
        return DateTime.Now.Year - birthDate.Year;
    }

    public override decimal CalculateSalary(decimal baseSalary)
    {
        return baseSalary;
    }

    public decimal CalculateBonusSalary(decimal baseSalary, int yearsOfExperience)
    {
        decimal bonus = yearsOfExperience * 1000;
        return baseSalary + bonus;
    }
}