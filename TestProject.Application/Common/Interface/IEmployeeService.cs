using TestProject.Application.Common.Dto;

namespace TestProject.Application.Common.Interface;

public interface IEmployeeService
{ 
    Task<List<EmployeeResponseDto>> GetEmployeeName();
    Task<EmployeeResponseDto> GetEmployeeById(Guid id);
}