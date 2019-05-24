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

		public static bool3 operator &(bool3 a, bool3 b) => new bool3(a.x & b.x, a.y & b.y, a.z & b.z);
		public static bool3 operator &(bool3 a, bool  b) => new bool3(a.x & b  , a.y & b  , a.z & b  );
		public static bool3 operator &(bool  a, bool3 b) => new bool3(a   & b.x, a   & b.y, a   & b.z);

		public static bool3 operator |(bool3 a, bool3 b) => new bool3(a.x | b.x, a.y | b.y, a.z | b.z);
		public static bool3 operator |(bool3 a, bool  b) => new bool3(a.x | b  , a.y | b  , a.z | b  );
		public static bool3 operator |(bool  a, bool3 b) => new bool3(a   | b.x, a   | b.y, a   | b.z);

		public static bool3 operator ^(bool3 a, bool3 b) => new bool3(a.x ^ b.x, a.y ^ b.y, a.z ^ b.z);
		public static bool3 operator ^(bool3 a, bool  b) => new bool3(a.x ^ b  , a.y ^ b  , a.z ^ b  );
		public static bool3 operator ^(bool  a, bool3 b) => new bool3(a   ^ b.x, a   ^ b.y, a   ^ b.z);

		public static bool3 operator !(bool3 val) => new bool3(!val.x, !val.y, !val.z);
	}

	public static partial class math
	{
		public static bool3 bool3(bool x, bool y, bool z) => new bool3(x, y, z);
		public static bool3 bool3(bool x) => new bool3(x);
	}
}