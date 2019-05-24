namespace RodMath
{
	public struct int4
	{
		public int x, y, z, w;

		public int4(int x, int y, int z, int w)
		{
			this.x = x;
			this.y = y;
			this.z = z;
			this.w = w;
		}

		public int4(int x)
		{
			this.x = x;
			this.y = x;
			this.z = x;
			this.w = x;
		}

		public static int4 operator +(int4 a, int4 b) => new int4(a.x + b.x, a.y + b.y, a.z + b.z, a.w + b.w);
		public static int4 operator +(int4 a, int  b) => new int4(a.x + b  , a.y + b  , a.z + b  , a.w + b  );
		public static int4 operator +(int  a, int4 b) => new int4(a   + b.x, a   + b.y, a   + b.z, a   + b.w);

		public static int4 operator -(int4 a, int4 b) => new int4(a.x - b.x, a.y - b.y, a.z - b.z, a.w - b.w);
		public static int4 operator -(int4 a, int  b) => new int4(a.x - b  , a.y - b  , a.z - b  , a.w - b  );
		public static int4 operator -(int  a, int4 b) => new int4(a   - b.x, a   - b.y, a   - b.z, a   - b.w);

		public static int4 operator *(int4 a, int4 b) => new int4(a.x * b.x, a.y * b.y, a.z * b.z, a.w * b.w);
		public static int4 operator *(int4 a, int  b) => new int4(a.x * b  , a.y * b  , a.z * b  , a.w * b  );
		public static int4 operator *(int  a, int4 b) => new int4(a   * b.x, a   * b.y, a   * b.z, a   * b.w);

		public static int4 operator /(int4 a, int4 b) => new int4(a.x / b.x, a.y / b.y, a.z / b.z, a.w / b.w);
		public static int4 operator /(int4 a, int  b) => new int4(a.x / b  , a.y / b  , a.z / b  , a.w / b  );
		public static int4 operator /(int  a, int4 b) => new int4(a   / b.x, a   / b.y, a   / b.z, a   / b.w);
	}

	public static partial class math
	{
		public static int4 int4(int x, int y, int z, int w) => new int4(x, y, z, w);
		public static int4 int4(int x) => new int4(x);
	}
}