namespace RodMath
{
	public struct int3
	{
		public int x, y, z;

		public int3(int x, int y, int z)
		{
			this.x = x;
			this.y = y;
			this.z = z;
		}

		public int3(int x)
		{
			this.x = x;
			this.y = x;
			this.z = x;
		}
	}

	public static partial class math
	{
		public static int3 int3(int x, int y, int z) => new int3(x, y, z);
		public static int3 int3(int x) => new int3(x);
	}
}