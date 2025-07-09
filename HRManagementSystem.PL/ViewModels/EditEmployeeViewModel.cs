using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;

namespace HRManagementSystem.PL.ViewModels
{
    public class EditEmployeeViewModel
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime DateOfBirth { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        public string Phone { get; set; }

        [Required]
        public string Department { get; set; }
        public List<SelectListItem> DepartmentOptions { get; set; }

        [Required]
        public string JopTitle { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime HireDate { get; set; }

        [Required]
        public string Status { get; set; }
        public List<SelectListItem> StatusOptions { get; set; }
    }
}
