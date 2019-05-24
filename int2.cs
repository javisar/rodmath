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

		public static bool2 operator ==(int2 a, int2 b) => new bool2(a.x == b.x, a.y == b.y);
		public static bool2 operator ==(int2 a, int  b) => new bool2(a.x == b  , a.y == b  );
		public static bool2 operator ==(int  a, int2 b) => new bool2(a   == b.x, a   == b.y);

		public static bool2 operator !=(int2 a, int2 b) => new bool2(a.x != b.x, a.y != b.y);
		public static bool2 operator !=(int2 a, int  b) => new bool2(a.x != b  , a.y != b  );
		public static bool2 operator !=(int  a, int2 b) => new bool2(a   != b.x, a   != b.y);

		public static bool2 operator < (int2 a, int2 b) => new bool2(a.x <  b.x, a.y <  b.y);
		public static bool2 operator < (int2 a, int  b) => new bool2(a.x <  b  , a.y <  b  );
		public static bool2 operator < (int  a, int2 b) => new bool2(a   <  b.x, a   <  b.y);

		public static bool2 operator > (int2 a, int2 b) => new bool2(a.x >  b.x, a.y >  b.y);
		public static bool2 operator > (int2 a, int  b) => new bool2(a.x >  b  , a.y >  b  );
		public static bool2 operator > (int  a, int2 b) => new bool2(a   >  b.x, a   >  b.y);

		public static bool2 operator <=(int2 a, int2 b) => new bool2(a.x <= b.x, a.y <= b.y);
		public static bool2 operator <=(int2 a, int  b) => new bool2(a.x <= b  , a.y <= b  );
		public static bool2 operator <=(int  a, int2 b) => new bool2(a   <= b.x, a   <= b.y);

		public static bool2 operator >=(int2 a, int2 b) => new bool2(a.x >= b.x, a.y >= b.y);
		public static bool2 operator >=(int2 a, int  b) => new bool2(a.x >= b  , a.y >= b  );
		public static bool2 operator >=(int  a, int2 b) => new bool2(a   >= b.x, a   >= b.y);

		public static int2 operator +(int2 a, int2 b) => new int2(a.x + b.x, a.y + b.y);
		public static int2 operator +(int2 a, int  b) => new int2(a.x + b  , a.y + b  );
		public static int2 operator +(int  a, int2 b) => new int2(a   + b.x, a   + b.y);

		public static int2 operator -(int2 a, int2 b) => new int2(a.x - b.x, a.y - b.y);
		public static int2 operator -(int2 a, int  b) => new int2(a.x - b  , a.y - b  );
		public static int2 operator -(int  a, int2 b) => new int2(a   - b.x, a   - b.y);

		public static int2 operator *(int2 a, int2 b) => new int2(a.x * b.x, a.y * b.y);
		public static int2 operator *(int2 a, int  b) => new int2(a.x * b  , a.y * b  );
		public static int2 operator *(int  a, int2 b) => new int2(a   * b.x, a   * b.y);

		public static int2 operator /(int2 a, int2 b) => new int2(a.x / b.x, a.y / b.y);
		public static int2 operator /(int2 a, int  b) => new int2(a.x / b  , a.y / b  );
		public static int2 operator /(int  a, int2 b) => new int2(a   / b.x, a   / b.y);

		public static int2 operator &(int2 a, int2 b) => new int2(a.x & b.x, a.y & b.y);
		public static int2 operator &(int2 a, int  b) => new int2(a.x & b  , a.y & b  );
		public static int2 operator &(int  a, int2 b) => new int2(a   & b.x, a   & b.y);

		public static int2 operator |(int2 a, int2 b) => new int2(a.x | b.x, a.y | b.y);
		public static int2 operator |(int2 a, int  b) => new int2(a.x | b  , a.y | b  );
		public static int2 operator |(int  a, int2 b) => new int2(a   | b.x, a   | b.y);

		public static int2 operator ^(int2 a, int2 b) => new int2(a.x ^ b.x, a.y ^ b.y);
		public static int2 operator ^(int2 a, int  b) => new int2(a.x ^ b  , a.y ^ b  );
		public static int2 operator ^(int  a, int2 b) => new int2(a   ^ b.x, a   ^ b.y);
	}

	public static partial class math
	{
		public static int2 int2(int x, int y) => new int2(x, y);
		public static int2 int2(int x) => new int2(x);
	}
}