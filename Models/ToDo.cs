using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ToDoApp.Models
{
    public class ToDo
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Please enter a description.")]
        public string Description { get; set; } = string.Empty;
        [Required(ErrorMessage ="Please enter a due date.")]
        public DateTime? DueDate { get; set; }
        [Required(ErrorMessage = "Please enter category.")]
        public string CategoryId { get; set; } = string.Empty;
        [ValidateNever] // Indicates that a property or parameter should be excluded from validation.
        public Category category { get; set; } = null!;
        [Required(ErrorMessage = "Please select a status.")]
        public string StatusId { get; set; } = string.Empty;
        [ValidateNever]
        public Status status { get; set; } = null!;
        public bool Overdue => StatusId == "open" && DueDate < DateTime.Today;
    }
}
