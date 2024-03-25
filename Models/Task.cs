using System.ComponentModel.DataAnnotations;

namespace Lab3_ToDoList.Models
{
	public class Task
	{
		public int Id { get; set; }

		[Required]
		public string Title { get; set; }
	}
}
