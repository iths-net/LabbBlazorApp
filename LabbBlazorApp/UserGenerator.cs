namespace LabbBlazorApp
{
	public class UserGenerator : IUserDal
	{
		private List<User>? _users;

		public IEnumerable<User> GetUsers() => _users!;

		public bool IsLoaded() => _users != null;

		public async void Load()
		{
			using var hc = new HttpClient();
			_users = await hc.GetFromJsonAsync<List<User>>("https://jsonplaceholder.typicode.com/users");
			/*var res = await hc.GetAsync("https://jsonplaceholder.typicode.com/users");
			res.EnsureSuccessStatusCode();
			users = (await res.Content.ReadFromJsonAsync<List<User>>())!;*/
		}
	}
}
