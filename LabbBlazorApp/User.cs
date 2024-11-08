namespace LabbBlazorApp
{
	public class User
	{
		public UserId Id { get; } = new();
		public required string Name { get; set; }
		public required string Email { get; set; }
		public required Address Address { get; set; }
		public required Company Company { get; set; }
	}
}
