using Microsoft.AspNetCore.Mvc;
using TestProject.Application.Common.Dto;
using TestProject.Application.Common.Interface;
using TestProject.Domain.Entities;

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
    
    [HttpGet("/api/employee/getById")]
    public async Task<EmployeeResponseDto> GetEmployeeById(Guid id)
    {
        var result = await _employeeService.GetEmployeeById(id);

        return result;
    }
}