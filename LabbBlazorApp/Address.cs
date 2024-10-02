using System.ComponentModel.DataAnnotations;

namespace LabbBlazorApp
{
	public class Address
	{
		[Required]
		[StringLength(40, MinimumLength = 5)]
		public string Street { get; set; }
		[Required]
		[StringLength(30, MinimumLength = 2)]
		public string City { get; set; }
		[Required]
		[StringLength(10, MinimumLength = 2)]
		public string ZipCode { get; set; }
	}
}
