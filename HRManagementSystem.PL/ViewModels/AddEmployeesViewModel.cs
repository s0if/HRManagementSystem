using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;

namespace HRManagementSystem.PL.ViewModels
{
    public class AddEmployeesViewModel
    {
        [Required(ErrorMessage = "Name is required.")]
        [StringLength(100, ErrorMessage = "Name must not exceed 100 characters.")]
        [Display(Name ="Name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Date of birth is required.")]
        [DataType(DataType.Date)]
        [Display(Name = "Date Of Birth")]
        public DateTime DateOfBirth { get; set; }

        [Required(ErrorMessage = "Email is required.")]
        [EmailAddress(ErrorMessage = "Invalid email address.")]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Phone number is required.")]
        [Phone(ErrorMessage = "Invalid phone number.")]
        [Display(Name = "Phone Number")]
        public string Phone { get; set; }

        [Required(ErrorMessage = "Department is required.")]
        [Display(Name = "Department")]
        public string Department { get; set; }
        public List<SelectListItem>? DepartmentOptions { get; set; }

        [Required(ErrorMessage = "Job title is required.")]
        [StringLength(50, ErrorMessage = "Job title must not exceed 50 characters.")]
        [Display(Name = "Jop Title")]
        public string JopTitle { get; set; }

        [Required(ErrorMessage = "Hire date is required.")]
        [DataType(DataType.Date)]
        [Display(Name = "Hire Date")]
        public DateTime HireDate { get; set; }

        [Required(ErrorMessage = "Employment status is required.")]
        [Display(Name = "Status")]
        public string Status { get; set; }
        public List<SelectListItem>? StatusOptions { get; set; }
    }
}
