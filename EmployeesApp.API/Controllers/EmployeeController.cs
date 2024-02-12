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
    public async Task<ActionResult<IEnumerable<Employee>>> Employees(int departamentId = 0,
                                                     string? fio = null,
                                                     DateTime? date = null,
                                                     DateTime? birthdate = null,
                                                     decimal? salary = null)
    {
        return Ok(await _employeeService.GetEmployees(departamentId, fio, date, birthdate, salary) );
    }

}
