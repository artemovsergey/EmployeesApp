using EmployeesApp.Application.Services;
using EmployeesApp.Domen.Models;
using Microsoft.AspNetCore.Mvc;

namespace EmployeesApp.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class EmployeesController : ControllerBase
{

    private readonly EmployeeService _employeeService;
    public EmployeesController(EmployeeService employeeService)
    {
        _employeeService = employeeService;
    }

    [HttpGet]
    public async Task<IEnumerable<Employee>> Employees()
    {
        return await _employeeService.GetEmployees();
    }

}
