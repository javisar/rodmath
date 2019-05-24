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

		public static bool2 operator &(bool2 a, bool2 b) => new bool2(a.x & b.x, a.y & b.y);
		public static bool2 operator &(bool2 a, bool  b) => new bool2(a.x & b  , a.y & b  );
		public static bool2 operator &(bool  a, bool2 b) => new bool2(a   & b.x, a   & b.y);

		public static bool2 operator |(bool2 a, bool2 b) => new bool2(a.x | b.x, a.y | b.y);
		public static bool2 operator |(bool2 a, bool  b) => new bool2(a.x | b  , a.y | b  );
		public static bool2 operator |(bool  a, bool2 b) => new bool2(a   | b.x, a   | b.y);

		public static bool2 operator ^(bool2 a, bool2 b) => new bool2(a.x ^ b.x, a.y ^ b.y);
		public static bool2 operator ^(bool2 a, bool  b) => new bool2(a.x ^ b  , a.y ^ b  );
		public static bool2 operator ^(bool  a, bool2 b) => new bool2(a   ^ b.x, a   ^ b.y);
	}

	public static partial class math
	{
		public static bool2 bool2(bool x, bool y) => new bool2(x, y);
		public static bool2 bool2(bool x) => new bool2(x);
	}
}