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

		public static bool3 operator ==(int3 a, int3 b) => new bool3(a.x == b.x, a.y == b.y, a.z == b.z);
		public static bool3 operator ==(int3 a, int  b) => new bool3(a.x == b  , a.y == b  , a.z == b  );
		public static bool3 operator ==(int  a, int3 b) => new bool3(a   == b.x, a   == b.y, a   == b.z);

		public static bool3 operator !=(int3 a, int3 b) => new bool3(a.x != b.x, a.y != b.y, a.z != b.z);
		public static bool3 operator !=(int3 a, int  b) => new bool3(a.x != b  , a.y != b  , a.z != b  );
		public static bool3 operator !=(int  a, int3 b) => new bool3(a   != b.x, a   != b.y, a   != b.z);

		public static bool3 operator < (int3 a, int3 b) => new bool3(a.x <  b.x, a.y <  b.y, a.z <  b.z);
		public static bool3 operator < (int3 a, int  b) => new bool3(a.x <  b  , a.y <  b  , a.z <  b  );
		public static bool3 operator < (int  a, int3 b) => new bool3(a   <  b.x, a   <  b.y, a   <  b.z);

		public static bool3 operator > (int3 a, int3 b) => new bool3(a.x >  b.x, a.y >  b.y, a.z >  b.z);
		public static bool3 operator > (int3 a, int  b) => new bool3(a.x >  b  , a.y >  b  , a.z >  b  );
		public static bool3 operator > (int  a, int3 b) => new bool3(a   >  b.x, a   >  b.y, a   >  b.z);

		public static bool3 operator <=(int3 a, int3 b) => new bool3(a.x <= b.x, a.y <= b.y, a.z <= b.z);
		public static bool3 operator <=(int3 a, int  b) => new bool3(a.x <= b  , a.y <= b  , a.z <= b  );
		public static bool3 operator <=(int  a, int3 b) => new bool3(a   <= b.x, a   <= b.y, a   <= b.z);

		public static bool3 operator >=(int3 a, int3 b) => new bool3(a.x >= b.x, a.y >= b.y, a.z >= b.z);
		public static bool3 operator >=(int3 a, int  b) => new bool3(a.x >= b  , a.y >= b  , a.z >= b  );
		public static bool3 operator >=(int  a, int3 b) => new bool3(a   >= b.x, a   >= b.y, a   >= b.z);

		public static int3 operator +(int3 a, int3 b) => new int3(a.x + b.x, a.y + b.y, a.z + b.z);
		public static int3 operator +(int3 a, int  b) => new int3(a.x + b  , a.y + b  , a.z + b  );
		public static int3 operator +(int  a, int3 b) => new int3(a   + b.x, a   + b.y, a   + b.z);

		public static int3 operator -(int3 a, int3 b) => new int3(a.x - b.x, a.y - b.y, a.z - b.z);
		public static int3 operator -(int3 a, int  b) => new int3(a.x - b  , a.y - b  , a.z - b  );
		public static int3 operator -(int  a, int3 b) => new int3(a   - b.x, a   - b.y, a   - b.z);

		public static int3 operator *(int3 a, int3 b) => new int3(a.x * b.x, a.y * b.y, a.z * b.z);
		public static int3 operator *(int3 a, int  b) => new int3(a.x * b  , a.y * b  , a.z * b  );
		public static int3 operator *(int  a, int3 b) => new int3(a   * b.x, a   * b.y, a   * b.z);

		public static int3 operator /(int3 a, int3 b) => new int3(a.x / b.x, a.y / b.y, a.z / b.z);
		public static int3 operator /(int3 a, int  b) => new int3(a.x / b  , a.y / b  , a.z / b  );
		public static int3 operator /(int  a, int3 b) => new int3(a   / b.x, a   / b.y, a   / b.z);

		public static int3 operator &(int3 a, int3 b) => new int3(a.x & b.x, a.y & b.y, a.z & b.z);
		public static int3 operator &(int3 a, int  b) => new int3(a.x & b  , a.y & b  , a.z & b  );
		public static int3 operator &(int  a, int3 b) => new int3(a   & b.x, a   & b.y, a   & b.z);

		public static int3 operator |(int3 a, int3 b) => new int3(a.x | b.x, a.y | b.y, a.z | b.z);
		public static int3 operator |(int3 a, int  b) => new int3(a.x | b  , a.y | b  , a.z | b  );
		public static int3 operator |(int  a, int3 b) => new int3(a   | b.x, a   | b.y, a   | b.z);

		public static int3 operator ^(int3 a, int3 b) => new int3(a.x ^ b.x, a.y ^ b.y, a.z ^ b.z);
		public static int3 operator ^(int3 a, int  b) => new int3(a.x ^ b  , a.y ^ b  , a.z ^ b  );
		public static int3 operator ^(int  a, int3 b) => new int3(a   ^ b.x, a   ^ b.y, a   ^ b.z);

		public static int3 operator -(int3 a) => new int3(-a.x, -a.y, -a.z);
		public static int3 operator ~(int3 a) => new int3(~a.x, ~a.y, ~a.z);

		public static int3 operator <<(int3 a, int b) => new int3(a.x << b, a.y << b, a.z << b);
		public static int3 operator >>(int3 a, int b) => new int3(a.x >> b, a.y >> b, a.z >> b);
	}

	public static partial class math
	{
		public static int3 int3(int x, int y, int z) => new int3(x, y, z);
		public static int3 int3(int x) => new int3(x);
	}
}