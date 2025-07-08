using HRManagementSystem.BLL.Interfaces;
using HRManagementSystem.DAL.Data;
using HRManagementSystem.DAL.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRManagementSystem.BLL.Repositories
{
    public class EmployeeRepositories : IEmployeeRepositories
    {
        private readonly ApplicationDbContext dbContext;

        public EmployeeRepositories(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public async Task<Employee> AddEmployee(Employee employee)
        {
            await dbContext.Employees.AddAsync(employee);
            await dbContext.SaveChangesAsync();
            return employee;
        }

        public async Task<Employee> DeleteEmployee(Employee employee)
        {
            dbContext.Employees.Remove(employee);
            await dbContext.SaveChangesAsync();

            return employee;
        }

        public async Task<List<Employee>> Employees()
        {
            return await dbContext.Employees.ToListAsync();
        }

        public async Task<Employee> GetEmployeeById(int id)
        {
            return await dbContext.Employees.FindAsync(id);
        }

        public async Task<Employee> UpdateEmployee(Employee employee)
        {
            dbContext.Employees.Update(employee);
            await dbContext.SaveChangesAsync();

            return employee;
        }
    }
}
