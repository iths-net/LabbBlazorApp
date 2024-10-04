namespace LabbBlazorApp
{
	public class User
	{
		public UserId Id { get; } = new();
		public required string Name { get; set; }
		public required string Email { get; set; }
		public Address Address { get; set; } = new();
		public Company Company { get; set; } = new();
	}
}
