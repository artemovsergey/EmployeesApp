namespace EmployeesApp.Domen.Models;

public class Employee
{
    public  int  Id { get; set; }
    public string Departament { get; set; }
    public string FullName { get; set; }
    public DateTime BirthDay { get; set; }
    public DateTime DateEmployment { get; set; }
    public decimal Salary { get; set; }

}
