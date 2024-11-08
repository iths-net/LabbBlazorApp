using LabbBlazorApp;

namespace LabbBlazorAppTest
{
	public class DummyDal : IUserDal
	{
		private IEnumerable<User>? _dummyUsers;

		public IEnumerable<User> GetUsers() =>
			_dummyUsers!;

		public bool IsLoaded() => _dummyUsers != null;

		public void Load() =>
			_dummyUsers = new [] { "joe", "andy", "willie", "nancy", "bobby" }.Select(name => new User
			{
				Name = name,
				Email = $"{name}@gmail.com",
				Address = new Address { City = "Cool city", Street = "Cool street 82", ZipCode = "Cool zip code" },
				Company = new Company { Name = "Cool company", CatchPhrase = "Cool catchphrase" }
			});
	}

	[TestClass]
	public class DummyDalTest
	{
		[TestMethod]
		public void NotLoaded() => Assert.IsFalse(new DummyDal().IsLoaded());

		[TestMethod]
		public void Load()
		{
			var dal = new DummyDal();

			Assert.IsNull(dal.GetUsers());

			dal.Load();

			var users = dal.GetUsers().ToArray();

			Assert.IsNotNull(users);

			foreach (var user in users)
				Assert.AreEqual(user.Name + "@gmail.com", user.Email);

			Assert.AreEqual(users.ElementAt(0).Address.Street, "Somewhere");
		}
	}
}