namespace RodMath
{
	public struct bool2
	{
		public bool x, y;

		public bool2(bool x, bool y)
		{
			this.x = x;
			this.y = y;
		}

		public bool2(bool x)
		{
			this.x = x;
			this.y = x;
		}
	}

	public static partial class math
	{
		public static bool2 bool2(bool x, bool y) => new bool2(x, y);
		public static bool2 bool2(bool x) => new bool2(x);
	}
}