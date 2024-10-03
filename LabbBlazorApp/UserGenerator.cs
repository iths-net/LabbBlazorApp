
namespace LabbBlazorApp
{
	public class UserGenerator : IUserCollection
	{
		public List<User> users;

		public UserGenerator()
		{
			users = [
				new() { Name = "joe", Email = "a" },
				new() { Name = "andy", Email = "b" },
				new() { Name = "willie", Email = "c" },
				new() { Name = "mary", Email = "d" },
				new() { Name = "bobby", Email = "e" },

				new() { Name = "E.T.", Email = "f" },
			];
		}

		public IEnumerable<User> GetUsers() => users;
	}
}
