using RazorPagesLessons.Models;
using System;
using System.Collections.Generic;

namespace RazorPagesLessons.Services
{
    public interface IEmployeeRepository
    {
        IEnumerable<Employee> GetAllEmployees();
    }
}
