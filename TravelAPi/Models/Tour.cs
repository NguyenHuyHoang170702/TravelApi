namespace TravelAPi.Models
{
	public class Tour
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public int Price { get; set; }
		public int Quantity { get; set; }
		public DateTime StartDate { get; set; }
		public DateTime EndDate { get; set; }
		public bool Status { get; set; }
	}
}
