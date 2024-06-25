using Microsoft.AspNetCore.Mvc;

namespace KhumaloCraftie.Models
{
	public class Order 
	{
		public int OrderId { get; set; }
		public int UserId { get; set; }
		public User User { get; set; }
		public DateTime OrderDate { get; set; }
		public string Status { get; set; }

	}
}
