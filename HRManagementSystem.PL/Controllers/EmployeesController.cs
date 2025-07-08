using HRManagementSystem.BLL.Interfaces;
using HRManagementSystem.DAL.Model;
using HRManagementSystem.PL.ViewModels;
using Mapster;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace HRManagementSystem.PL.Controllers
{
    public class EmployeesController : Controller
    {
        private readonly IEmployeeRepositories repositories;

        public EmployeesController(IEmployeeRepositories repositories)
        {
            this.repositories = repositories;
        }
        public IActionResult AddEmployee()
        {
            var model = new AddEmployeesViewModel
            {
                DepartmentOptions = new List<SelectListItem>
                {
                    new SelectListItem { Value = "Human Resources", Text = "Human Resources" },
                    new SelectListItem { Value = "IT", Text = "IT" },
                    new SelectListItem { Value = "Sales", Text = "Sales" },
                    new SelectListItem { Value = "Finance", Text = "Finance" },
                }  ,
                StatusOptions=new List<SelectListItem>
                {
                    new SelectListItem { Value = "Active", Text = "Active" },
                    new SelectListItem { Value = "On Leave", Text = "On Leave" },
                    new SelectListItem { Value = "Terminated", Text = "Terminated" },

                }
            };
            return View(model);

        }
        [HttpPost]
        public async Task<IActionResult> AddEmployee(AddEmployeesViewModel model)
        {
            if (!ModelState.IsValid)
            {
                model = new AddEmployeesViewModel
                {
                    DepartmentOptions = new List<SelectListItem>
                    {
                        new SelectListItem { Value = "Human Resources", Text = "Human Resources" },
                        new SelectListItem { Value = "IT", Text = "IT" },
                        new SelectListItem { Value = "Sales", Text = "Sales" },
                        new SelectListItem { Value = "Finance", Text = "Finance" },
                    },
                    StatusOptions = new List<SelectListItem>
                    {
                        new SelectListItem { Value = "Active", Text = "Active" },
                        new SelectListItem { Value = "On Leave", Text = "On Leave" },
                        new SelectListItem { Value = "Terminated", Text = "Terminated" },
                    }
                };
                return View(model);
            }
            var employee = new Employee
            {
                Name = model.Name,
                DateOfBirth = model.DateOfBirth,
                Email = model.Email,
                Phone = model.Phone,
                Department = model.Department,
                JopTitle = model.JopTitle,
                HireDate = model.HireDate,
                Status = model.Status
            };
            
           await repositories.AddEmployee(employee);
            return RedirectToAction(nameof(AllEmployee));
        }
        
        public async Task<IActionResult> AllEmployee()
        {
            var employees = await repositories.Employees();
            var result = employees.Select(emp => new AllEmployeeViewModel
            {
                Id = emp.Id,
                Name = emp.Name,
                Department = emp.Department,
                JopTitle = emp.JopTitle,
                Status = emp.Status
            });
            return View(result);
        }

        public async Task<IActionResult> DeleteEmployee(int Id)
        {
           var employee= await repositories.GetEmployeeById(Id);
            await repositories.DeleteEmployee(employee);
            return RedirectToAction(nameof(AllEmployee));

        }

        public async Task<IActionResult> DetailsEmployee(int Id)
        {
            Employee employee=await repositories.GetEmployeeById(Id);  
            var result =employee.Adapt<DetailsEmployeeViewModel>();
            return View(result);
        }
        public async Task<IActionResult> EditEmployee(int Id)
        {
            Employee employee=await repositories.GetEmployeeById(Id);
            var result = employee.Adapt<DetailsEmployeeViewModel>();

            return View(result);
        }
        [HttpPost]
        public async Task<IActionResult> EditEmployee(DetailsEmployeeViewModel model)
        {
            if (!ModelState.IsValid) 
                return View(model);
            var result = model.Adapt<Employee>();

            var editEmployee = await repositories.UpdateEmployee(result);
            return RedirectToAction(nameof(AllEmployee));
        }

    }
}
