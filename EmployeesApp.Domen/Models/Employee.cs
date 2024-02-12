namespace EmployeesApp.Domen.Models;

public class Employee
{
    public  int  Id { get; set; }
    public string FullName { get; set; }
    public DateTime BirthDay { get; set; }
    public DateTime DateEmployment { get; set; }
    public decimal Salary { get; set; }

    public int DepartamentId { get; set; }
    public virtual Departament? Departament { get; set; } = null;

}
