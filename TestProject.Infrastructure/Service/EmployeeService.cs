using Microsoft.EntityFrameworkCore;
using TestProject.Application.Common.Dto;
using TestProject.Application.Common.Interface;

namespace TestProject.Infrastructure.Service;

public class EmployeeService : IEmployeeService
{
    private readonly IApplicationDbContext _dbContext;
    public EmployeeService(IApplicationDbContext dbContext)
    {
        _dbContext = dbContext;
    }
    
    public async Task<List<EmployeeResponseDto>> GetEmployeeName()
    {
        var employeeList = await _dbContext.Employee.ToListAsync();

        var result = employeeList.Select(item => new EmployeeResponseDto
        {
            FirstName = item.FirstName,
            LastName = item.LastName,
            Salary = item.Salary
        }).ToList();

        return result;
    }
}