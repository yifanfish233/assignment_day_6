namespace OOD;

public interface IPersonService
{
    int CalculateAge(DateTime birthDate);
    decimal CalculateSalary(decimal baseSalary);
    List<string> GetAddresses();
}




