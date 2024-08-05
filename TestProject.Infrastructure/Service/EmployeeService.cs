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

    public async Task<EmployeeResponseDto> GetEmployeeById(Guid id)
    {
        var employeeData = await _dbContext.Employee.FirstOrDefaultAsync(x => x.Id == id);

        var result = new EmployeeResponseDto();
        if (employeeData != null)
        {
             result = new EmployeeResponseDto
            {
                FirstName = employeeData.FirstName,
                LastName = employeeData.LastName,
                Salary = employeeData.Salary
            };
        }
        return result;
    }
}