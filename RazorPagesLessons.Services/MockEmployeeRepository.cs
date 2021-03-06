using RazorPagesLessons.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace RazorPagesLessons.Services
{
    public class MockEmployeeRepository : IEmployeeRepository
    {
        private List<Employee> employeeList;
        // ctor + tab => создать конструктор
        public MockEmployeeRepository()
        {
            this.employeeList = new List<Employee>()
            {
                new Employee() { Id = 0, Name = "Mery", Email = "mary@example.com", PhotoPath = "avatar2.png", Department = Department.HR },
                new Employee() { Id = 1, Name = "MerK", Email = "mark@example.com", PhotoPath = "avatar.png", Department = Department.IT },
                new Employee() { Id = 2, Name = "Smit", Email = "smit@example.com", PhotoPath = "avatar4.png", Department = Department.IT },
                new Employee() { Id = 3, Name = "Shawn", Email = "shawn@example.com", PhotoPath = "avatar5.png", Department = Department.Payroll },
                new Employee() { Id = 4, Name = "Jenifer", Email = "jenifer@example.com", PhotoPath = "avatar3.png", Department = Department.HR },
                new Employee() { Id = 5, Name = "Sten", Email = "sten@example.com", Department = Department.Payroll }
            };
        }
        public IEnumerable<Employee> GetAllEmployees()
        {
            return this.employeeList;
        }
    }
}
