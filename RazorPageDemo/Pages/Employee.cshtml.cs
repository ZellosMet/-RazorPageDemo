using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorPageDemo.Pages
{
    public class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }

        public Employee(int id, string firstName, string lastName, DateTime date)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            DateOfBirth = date;
        }
    }

    public class EmployeeModel : PageModel
    {
        [BindProperty(SupportsGet = true)]        
        public int Id {get; set;}
        public List<Employee> EmployeeList { get; set; }
        public EmployeeModel(List<Employee> employee_list)
        {
            EmployeeList = employee_list;
            EmployeeList.Add(new Employee(1, "Иван", "Кучеренко", new DateTime(1980, 7, 20)));
            EmployeeList.Add(new Employee(2, "Владимир", "Путилин", new DateTime(1990, 5, 10)));
            EmployeeList.Add(new Employee(3, "Магомед", "Судорчук", new DateTime(2000, 3, 5)));
        }

        public void OnGet(int id)
        {
            if (id == 0) this.Id = 1;
        }
    }
}
