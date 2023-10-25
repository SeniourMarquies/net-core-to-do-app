using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ToDoApp.Models
{
	/// <summary>
	/// Represents a To-Do item with various properties for tracking tasks.
	/// </summary>
	public class ToDo
	{
		/// <summary>
		/// Gets or sets the unique identifier of the To-Do item.
		/// </summary>
		public int Id { get; set; }

		/// <summary>
		/// Gets or sets the description of the To-Do item.
		/// </summary>
		[Required(ErrorMessage = "Please enter a description.")]
		public string Description { get; set; } = string.Empty;

		/// <summary>
		/// Gets or sets the due date for the To-Do item.
		/// </summary>
		[Required(ErrorMessage = "Please enter a due date.")]
		public DateTime? DueDate { get; set; }

		/// <summary>
		/// Gets or sets the category identifier for the To-Do item.
		/// </summary>
		[Required(ErrorMessage = "Please enter a category.")]
		public string CategoryId { get; set; } = string.Empty;

		/// <summary>
		/// Gets or sets the Category object associated with the To-Do item.
		/// </summary>
		[ValidateNever]
		public Category category { get; set; } = null!;

		/// <summary>
		/// Gets or sets the status identifier for the To-Do item.
		/// </summary>
		[Required(ErrorMessage = "Please select a status.")]
		public string StatusId { get; set; } = string.Empty;

		/// <summary>
		/// Gets or sets the Status object associated with the To-Do item.
		/// </summary>
		[ValidateNever]
		public Status status { get; set; } = null!;

		/// <summary>
		/// Gets a boolean value indicating whether the To-Do item is overdue.
		/// </summary>
		public bool Overdue => StatusId == "open" && DueDate < DateTime.Today;
	}

}
