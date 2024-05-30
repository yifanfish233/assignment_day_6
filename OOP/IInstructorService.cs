namespace OOD;

public interface IInstructorService : IPersonService
{
    decimal CalculateBonusSalary(decimal baseSalary, int yearsOfExperience);
}