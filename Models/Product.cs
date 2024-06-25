using Microsoft.AspNetCore.Mvc;

namespace KhumaloCraftie.Models
{
	public class Product 
	{
		public int ProductId { get; set; }
		public string Name { get; set; }
		public decimal Price { get; set; }
		public string Category { get; set; }
		public bool Availability { get; set; }
		public string ImageUrl { get; set; }
		public string Description { get; set; }
	}
}
