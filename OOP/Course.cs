namespace OOD;

public class Course
{
    public string CourseName { get; set; }
    public List<Student> EnrolledStudents { get; set; }

    public Course(string courseName)
    {
        CourseName = courseName;
        EnrolledStudents = new List<Student>();
    }
}