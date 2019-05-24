namespace RodMath
{
	public struct int2
	{
		public int x, y;

		public int2(int x, int y)
		{
			this.x = x;
			this.y = y;
		}

		public int2(int x)
		{
			this.x = x;
			this.y = x;
		}
	}

	public static partial class math
	{
		public static int2 int2(int x, int y) => new int2(x, y);
		public static int2 int2(int x) => new int2(x);
	}
}