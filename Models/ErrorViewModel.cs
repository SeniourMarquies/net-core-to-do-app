namespace ToDoApp.Models
{
	public class ErrorViewModel
	{
		// A property to store a unique identifier for a specific error request.
		public string? RequestId { get; set; }

		// A computed property that returns true if RequestId is not null or empty,
		// indicating whether to show the RequestId in the error view.
		public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
	}
	}

