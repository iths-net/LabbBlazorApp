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

	public class UserId
	{
		public string Uid { get; }
		public UserId()
		{
			Uid = new Random().Next((int)Math.Pow(10, 7), (int)Math.Pow(10, 8)).ToString();
		}

		public override string ToString() => Uid;
	}

	public static class UserManager
	{
		public static List<User>? users = GenerateUsers();

		private static List<User> GenerateUsers() =>
			[
				new() {
					Name = "name goes here",
                    Email = "email goes here",
                }
			];
	}
}
