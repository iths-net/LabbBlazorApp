using System.Net;

namespace LabbBlazorApp
{
	public class UserGenerator : IUserDAL
	{
		private List<User>? users;

		public IEnumerable<User> GetUsers() => users!;

		public bool IsLoaded() => users != null;

		public async void Load()
		{
			using (var hc = new HttpClient())
			{
				var res = await hc.GetAsync("https://jsonplaceholder.typicode.com/users");
				res.EnsureSuccessStatusCode();
				users = (await res.Content.ReadFromJsonAsync<List<User>>())!;
			}
		}
	}
}
