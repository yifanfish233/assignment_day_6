namespace OOD;

public class Department
{
    public string DepartmentName { get; set; }
    public Instructor HeadOfDepartment { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public List<Course> Courses { get; set; }

    public Department(string departmentName, DateTime startDate, DateTime endDate)
    {
        DepartmentName = departmentName;
        StartDate = startDate;
        EndDate = endDate;
        Courses = new List<Course>();
    }
}