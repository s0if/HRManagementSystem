using HRManagementSystem.DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRManagementSystem.BLL.Interfaces
{
    public interface IEmployeeRepositories
    {
        public Task<Employee> AddEmployee(Employee employee);
        public Task<Employee> UpdateEmployee(Employee employee);
        public Task<Employee> DeleteEmployee(Employee employee);
        public Task<List<Employee>> Employees();
        public Task<Employee> GetEmployeeById(int Id);
    }
}
