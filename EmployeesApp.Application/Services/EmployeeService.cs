using EmployeesApp.Domen.Interfaces;
using EmployeesApp.Domen.Models;

namespace EmployeesApp.Application.Services;

public class EmployeeService
{
    private readonly IEmployeeRepository _repository;
    public EmployeeService(IEmployeeRepository repository)
    {
        _repository = repository;
    }

    public async Task<IEnumerable<Employee>> GetEmployees()
    {
       return await _repository.GetEmployees();
    }


}
