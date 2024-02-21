using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace TravelAPi.Models
{
	public class ApplicationUser
	{
		[Required]
		public string Name { get; set; }

		public string? StressAddress { get; set; }
		public string? City { get; set; }

		public string? State { get; set; }

		public string? PostalCode { get; set; }

		[NotMapped]
		public string Role { get; set; }
	}
}
