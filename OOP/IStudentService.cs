namespace OOD;

public interface IStudentService : IPersonService
{
    double CalculateGPA(List<string> grades);
}