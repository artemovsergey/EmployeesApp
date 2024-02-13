
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
                                                     decimal? salary = null,
                                                     string sortColumn = "FullName",
                                                     string sortOrder = "ASC")
    {
        return Ok(await _employeeService.GetEmployees(departamentId,
                                                      fio,
                                                      date,
                                                      birthdate,
                                                      salary,
                                                      sortColumn,
                                                      sortOrder) );
    }


    // POST: api/Employees
    [HttpPost]
    public async Task<ActionResult> SignUser(Employee e)
    {
        //var validationResult = _userValidator.Validate(e);

        //if (!validationResult.IsValid)
        //{
        //    foreach (var failure in validationResult.Errors)
        //    {
        //        ModelState.AddModelError(failure.PropertyName, failure.ErrorMessage);
        //    }

        //    return BadRequest(ModelState);
        //}

        await _employeeService.Create(e);
        return CreatedAtAction(nameof(GetUserById), new { id = e.Id }, e);
    }

    // GET: api/Employees/5
    [HttpGet("{id}")]
    public async Task<ActionResult<Employee>> GetUserById(int id)
    {
        var e = new Employee(); //await _employeeService.GetById(id);

        if (e == null)
        {
            return NotFound();
        }

        return e;
    }

    // PUT: api/Employees/5
    [HttpPut("{id}")]
    public async Task<IActionResult> PutUser(int id, Employee e)
    {
        if (id != e.Id)
        {
            return NotFound();
        }

        try
        {
            await _employeeService.Edit(e);
        }
        catch
        {
            return NotFound();
        }

        return NoContent();
    }

    // DELETE: api/Employees/5
    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteUser(Employee e)
    {
        try
        {
            await _employeeService.Delete(e);
        }
        catch
        {
            return NotFound();
        }

        return NoContent();
    }

    [HttpGet("/generate")]
    public async Task<IActionResult> SeedEmployees()
    {

        var faker = new Faker<Employee>();
        //.RuleFor(u => u.Id, f => f.UniqueIndex)
        //.RuleFor(u => u.Email, f => f.Internet.Email())
        //.RuleFor(u => u.Login, f => f.Person.UserName)
        //.RuleFor(u => u.Password, f => f.Internet.Password());

        //List<Employee> Employees = faker.Generate(100);

        //using (var context = new EmployeeContext())
        //{
        //    context.Employees.AddRangeAsync(Employees);
        //    await context.SaveChangesAsync();
        //}

        return Ok();
    }

    [HttpPost]
    [Route("isUniqEmail")]
    public async Task<bool> isUniqEmail(Employee e)
    {
        //return await _employeeService.IsUniqEmail(e);
        return true;
    }


}
