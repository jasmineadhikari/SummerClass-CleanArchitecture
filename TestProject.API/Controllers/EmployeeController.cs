using Microsoft.AspNetCore.Mvc;
using TestProject.Application.Common.Dto;
using TestProject.Application.Common.Interface;

namespace TestProject.API.Controllers;

[ApiController]
public class EmployeeController : ControllerBase
{
    private readonly IEmployeeService _employeeService;
    public EmployeeController(IEmployeeService employeeService)
    {
        _employeeService = employeeService;
    }
    
    [HttpGet]
    [Route("/api/employee/all-employee")]
    public async Task<List<EmployeeResponseDto>> GetListOfEmployee()
    {
        var result = await _employeeService.GetEmployeeName();

        return result;
    }
}