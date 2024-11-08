namespace LabbBlazorApp
{
	public interface IUserDal
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
