namespace LabbBlazorApp
{
	public interface IUserDAL
	{
		IEnumerable<User> GetUsers();

		void Load();

		bool LoadIfNeeded()
		{
			var wasLoaded = IsLoaded();
			if (!wasLoaded)
				Load();
			return !wasLoaded;
		}

		bool IsLoaded();
	}
}
