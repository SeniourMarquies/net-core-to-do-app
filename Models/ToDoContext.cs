using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography.X509Certificates;

namespace ToDoApp.Models
{
	

	/// <summary>
	/// Represents the database context for managing ToDo, Category, and Status entities.
	/// </summary>
	public class ToDoContext : DbContext
	{
		/// <summary>
		/// Initializes a new instance of the ToDoContext class.
		/// </summary>
		/// <param name="options">The options for configuring the database context.</param>
		public ToDoContext(DbContextOptions<ToDoContext> options) : base(options)
		{
			// Constructor for setting up the database context.
		}

		/// <summary>
		/// Gets or sets the DbSet for ToDo entities in the database.
		/// </summary>
		public DbSet<ToDo> ToDos { get; set; } = null!;

		/// <summary>
		/// Gets or sets the DbSet for Category entities in the database.
		/// </summary>
		public DbSet<Category> Categories { get; set; } = null!;

		/// <summary>
		/// Gets or sets the DbSet for Status entities in the database.
		/// </summary>
		public DbSet<Status> Statuses { get; set; } = null!;

		/// <summary>
		/// Overrides the OnModelCreating method to configure the database model and seed data.
		/// </summary>
		/// <param name="modelBuilder">The ModelBuilder instance used for configuring the model.</param>
		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			// Configure and seed data for the Category and Status entities.
			modelBuilder.Entity<Category>().HasData(
				new Category { CategoryId = "work", Name = "Work" },
				new Category { CategoryId = "home", Name = "Home" },
				new Category { CategoryId = "ex", Name = "Exercise" },
				new Category { CategoryId = "shop", Name = "Shopping" },
				new Category { CategoryId = "call", Name = "Contact" }
			);

			modelBuilder.Entity<Status>().HasData(
				new Status { StatusId = "open", Name = "Open" },
				new Status { StatusId = "closed", Name = "Completed" }
			);

			// Call the base class's OnModelCreating method for any additional configuration.
			base.OnModelCreating(modelBuilder);
		}
	}

}
