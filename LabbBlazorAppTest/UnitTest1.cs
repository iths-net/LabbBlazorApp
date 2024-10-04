using LabbBlazorApp;

namespace LabbBlazorAppTest
{
	public class DummyDAL : IUserDAL
	{
		private User[]? dummyUsers;

		public IEnumerable<User> GetUsers() =>
			dummyUsers!;

		public bool IsLoaded() => dummyUsers != null;

		public void Load() =>
			dummyUsers = [
				new() { Name = "joe", Email = "joe@gmail.com", Address = new() { Street = "Somewhere" } },
				new() { Name = "andy", Email = "andy@gmail.com" },
				new() { Name = "willie", Email = "willie@gmail.com" },
				new() { Name = "mary", Email = "mary@gmail.com" },
				new() { Name = "bobby", Email = "bobby@gmail.com" },
			];
	}

	[TestClass]
	public class DummyDalTest
	{
		[TestMethod]
		public void NotLoaded() => Assert.IsFalse(new DummyDAL().IsLoaded());

		[TestMethod]
		public void Load()
		{
			var dal = new DummyDAL();

			Assert.IsNull(dal.GetUsers());

			dal.Load();

			var users = dal.GetUsers();

			Assert.IsNotNull(users);

			foreach (var user in users)
				Assert.AreEqual(user.Name + "@gmail.com", user.Email);

			Assert.AreEqual(users.ElementAt(0).Address.Street, "Somewhere");
		}
	}
}