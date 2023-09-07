using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SmartFactory_MinProject.Models
{
	public class Comment
	{
		public int Id { get; set; }
		[Required]
		public string Content { get; set; }

		public DateTime Date { get; set; }

		public int CodeboardId { get; set; }
		
		[ForeignKey("CodeboardId")]
		public Codeboard Codeboard { get; set; }
		

	}
}
