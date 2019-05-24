namespace RodMath
{
	public struct bool3
	{
		public bool x, y, z;

		public bool3(bool x, bool y, bool z)
		{
			this.x = x;
			this.y = y;
			this.z = z;
		}

		public bool3(bool x)
		{
			this.x = x;
			this.y = x;
			this.z = x;
		}
	}

	public static partial class math
	{
		public static bool3 bool3(bool x, bool y, bool z) => new bool3(x, y, z);
		public static bool3 bool3(bool x) => new bool3(x);
	}
}