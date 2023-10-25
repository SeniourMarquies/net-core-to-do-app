namespace ToDoApp.Models
{
    public class Filters
    {
		// Constructor for the Filters class
		public Filters(string filterstring)
		{
			// Initialize FilterString with the provided filterstring or default to "all-all-all"
			FilterString = filterstring ?? "all-all-all";

			// Split the FilterString into individual filter components using the '-' delimiter
			string[] filters = FilterString.Split('-');

			// Extract and assign values to the CategoryId, Due, and StatusId properties
			CategoryId = filters[0];
			Due = filters[1];
			StatusId = filters[2];
		}

		// Property to store the original filter string
		public string FilterString { get; }

		// Property to store the Category ID
		public string CategoryId { get; }

		// Property to store the Due value
		public string Due { get; }

		// Property to store the Status ID
		public string StatusId { get; }

		// Property that checks if a specific Category is selected (not "all")
		public bool HasCategory => CategoryId.ToLower() != "all";

		// Property that checks if a specific Due value is selected (not "all")
		public bool HasDue => Due.ToLower() != "all";

		// Property that checks if a specific Status is selected (not "all")
		public bool HasStatus => StatusId.ToLower() != "all";

		// Dictionary to map Due filter values to their corresponding labels
		public static Dictionary<string, string> DueFilterValues =>
			new Dictionary<string, string> {
			{ "future", "Future" },
			{ "past", "Past" },
			{ "today", "Today" }
			};

		// Property that checks if the Due value is "past"
		public bool IsPast => Due.ToLower() == "past";

		// Property that checks if the Due value is "future"
		public bool IsFuture => Due.ToLower() == "future";

		// Property that checks if the Due value is "today"
		public bool IsToday => Due.ToLower() == "today";
	}
}
