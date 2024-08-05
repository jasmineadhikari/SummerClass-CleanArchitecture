using TestProject.Domain.Shared;

namespace TestProject.Domain.Entities;

public class Employee : BaseEntity
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public float Salary { get; set; }
}