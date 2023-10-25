namespace ToDoApp.Models
{
	/// <summary>
	/// The Category class represents a category in a system.
	/// </summary>
	public class Category
	{
		/// <summary>
		/// Gets or sets the unique identifier of the category.
		/// </summary>
		public string CategoryId { get; set; } = string.Empty;

		/// <summary>
		/// Gets or sets the name of the category.
		/// </summary>
		public string Name { get; set; } = string.Empty;
	}

}