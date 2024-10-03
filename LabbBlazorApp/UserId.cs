namespace LabbBlazorApp
{
	public class UserId : IComparable
	{
		public string Uid { get; }

		public UserId()
		{
			Uid = new Random().Next((int)Math.Pow(10, 7), (int)Math.Pow(10, 8)).ToString();
		}

		public override string ToString() => Uid;

		public int CompareTo(object? obj)
			=> ToString().CompareTo(obj?.ToString());
	}
}
