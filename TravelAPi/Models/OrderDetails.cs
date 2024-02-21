using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace TravelAPi.Models
{
	public class OrderDetails
	{
		public int Id { get; set; }

		[Required]
		public int OrderHeaderId { get; set; }
		[ForeignKey(nameof(OrderHeaderId))]
		[ValidateNever]
		public OrderHeader OrderHeader { get; set; }

		public int Count { get; set; }

		public double Price { get; set; }
	}
}
