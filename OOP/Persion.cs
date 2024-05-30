namespace OOD;

public abstract class Person : IPersonService
{
    public string Name { get; set; }
    public DateTime BirthDate { get; set; }
    public List<string> Addresses { get; set; }

    public Person(string name, DateTime birthDate)
    {
        Name = name;
        BirthDate = birthDate;
        Addresses = new List<string>();
    }
    public abstract int CalculateAge(DateTime birthDate);
    public abstract decimal CalculateSalary(decimal baseSalary);

    public List<string> GetAddresses()
    {
        return Addresses;
    }
}




