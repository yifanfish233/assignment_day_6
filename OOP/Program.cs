// See https://aka.ms/new-console-template for more information
namespace OOD;
class Program
{
    static void Main(string[] args)
    {
        Student student = new Student("Alice", new DateTime(2000, 5, 15));
        student.Courses.Add("Math");
        student.Courses.Add("Science");

        Instructor instructor = new Instructor("Bob", new DateTime(1980, 8, 20), "Computer Science", new DateTime(2010, 9, 1));
        instructor.IsHeadOfDepartment = true;
        
        List<string> grades = new List<string> { "A", "B", "A", "C" };
        double gpa = student.CalculateGPA(grades);
        Console.WriteLine($"Student GPA: {gpa}");

  
        int experience = instructor.CalculateAge(instructor.JoinDate);
        decimal bonusSalary = instructor.CalculateBonusSalary(50000, experience);
        Console.WriteLine($"Instructor Bonus Salary: {bonusSalary}");
    }
}
