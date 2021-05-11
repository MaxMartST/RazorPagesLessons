using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPagesLessons.Models;
using RazorPagesLessons.Services;

namespace RazorPagesGeneral.Pages.Employees
{
    public class EmployeesModel : PageModel
    {
        private readonly IEmployeeRepository db;
        public EmployeesModel(IEmployeeRepository db)
        {
            this.db = db;
        }
        public IEnumerable<Employee> Employees { get; set; }
        public void OnGet()
        {
            // получить список всех сотрудников
            Employees = this.db.GetAllEmployees();
        }
    }
}
