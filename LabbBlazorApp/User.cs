namespace LabbBlazorApp
{
	public class User
	{
		public UserId Id { get; } = new();
		public string Name { get; set; }
		public string Email { get; set; }
		public Address Addr { get; set; } = new();
		public Company Comp { get; set; } = new();
	}
}
