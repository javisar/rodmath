using System.Runtime.CompilerServices;

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

		public override bool Equals(object obj) => obj is int3 a && math.all(this == a);
		public override int GetHashCode() => x ^ (y * 2718281) ^ (z * 314159);

		const MethodImplOptions Inline = MethodImplOptions.AggressiveInlining;

		[MethodImpl(Inline)] public static bool3 operator ==(int3 a, int3 b) => new bool3(a.x == b.x, a.y == b.y, a.z == b.z);
		[MethodImpl(Inline)] public static bool3 operator ==(int3 a, int  b) => new bool3(a.x == b  , a.y == b  , a.z == b  );
		[MethodImpl(Inline)] public static bool3 operator ==(int  a, int3 b) => new bool3(a   == b.x, a   == b.y, a   == b.z);

		[MethodImpl(Inline)] public static bool3 operator !=(int3 a, int3 b) => new bool3(a.x != b.x, a.y != b.y, a.z != b.z);
		[MethodImpl(Inline)] public static bool3 operator !=(int3 a, int  b) => new bool3(a.x != b  , a.y != b  , a.z != b  );
		[MethodImpl(Inline)] public static bool3 operator !=(int  a, int3 b) => new bool3(a   != b.x, a   != b.y, a   != b.z);

		[MethodImpl(Inline)] public static bool3 operator < (int3 a, int3 b) => new bool3(a.x <  b.x, a.y <  b.y, a.z <  b.z);
		[MethodImpl(Inline)] public static bool3 operator < (int3 a, int  b) => new bool3(a.x <  b  , a.y <  b  , a.z <  b  );
		[MethodImpl(Inline)] public static bool3 operator < (int  a, int3 b) => new bool3(a   <  b.x, a   <  b.y, a   <  b.z);

		[MethodImpl(Inline)] public static bool3 operator > (int3 a, int3 b) => new bool3(a.x >  b.x, a.y >  b.y, a.z >  b.z);
		[MethodImpl(Inline)] public static bool3 operator > (int3 a, int  b) => new bool3(a.x >  b  , a.y >  b  , a.z >  b  );
		[MethodImpl(Inline)] public static bool3 operator > (int  a, int3 b) => new bool3(a   >  b.x, a   >  b.y, a   >  b.z);

		[MethodImpl(Inline)] public static bool3 operator <=(int3 a, int3 b) => new bool3(a.x <= b.x, a.y <= b.y, a.z <= b.z);
		[MethodImpl(Inline)] public static bool3 operator <=(int3 a, int  b) => new bool3(a.x <= b  , a.y <= b  , a.z <= b  );
		[MethodImpl(Inline)] public static bool3 operator <=(int  a, int3 b) => new bool3(a   <= b.x, a   <= b.y, a   <= b.z);

		[MethodImpl(Inline)] public static bool3 operator >=(int3 a, int3 b) => new bool3(a.x >= b.x, a.y >= b.y, a.z >= b.z);
		[MethodImpl(Inline)] public static bool3 operator >=(int3 a, int  b) => new bool3(a.x >= b  , a.y >= b  , a.z >= b  );
		[MethodImpl(Inline)] public static bool3 operator >=(int  a, int3 b) => new bool3(a   >= b.x, a   >= b.y, a   >= b.z);

		[MethodImpl(Inline)] public static int3 operator +(int3 a, int3 b) => new int3(a.x + b.x, a.y + b.y, a.z + b.z);
		[MethodImpl(Inline)] public static int3 operator +(int3 a, int  b) => new int3(a.x + b  , a.y + b  , a.z + b  );
		[MethodImpl(Inline)] public static int3 operator +(int  a, int3 b) => new int3(a   + b.x, a   + b.y, a   + b.z);

		[MethodImpl(Inline)] public static int3 operator -(int3 a, int3 b) => new int3(a.x - b.x, a.y - b.y, a.z - b.z);
		[MethodImpl(Inline)] public static int3 operator -(int3 a, int  b) => new int3(a.x - b  , a.y - b  , a.z - b  );
		[MethodImpl(Inline)] public static int3 operator -(int  a, int3 b) => new int3(a   - b.x, a   - b.y, a   - b.z);

		[MethodImpl(Inline)] public static int3 operator *(int3 a, int3 b) => new int3(a.x * b.x, a.y * b.y, a.z * b.z);
		[MethodImpl(Inline)] public static int3 operator *(int3 a, int  b) => new int3(a.x * b  , a.y * b  , a.z * b  );
		[MethodImpl(Inline)] public static int3 operator *(int  a, int3 b) => new int3(a   * b.x, a   * b.y, a   * b.z);

		[MethodImpl(Inline)] public static int3 operator /(int3 a, int3 b) => new int3(a.x / b.x, a.y / b.y, a.z / b.z);
		[MethodImpl(Inline)] public static int3 operator /(int3 a, int  b) => new int3(a.x / b  , a.y / b  , a.z / b  );
		[MethodImpl(Inline)] public static int3 operator /(int  a, int3 b) => new int3(a   / b.x, a   / b.y, a   / b.z);

		[MethodImpl(Inline)] public static int3 operator &(int3 a, int3 b) => new int3(a.x & b.x, a.y & b.y, a.z & b.z);
		[MethodImpl(Inline)] public static int3 operator &(int3 a, int  b) => new int3(a.x & b  , a.y & b  , a.z & b  );
		[MethodImpl(Inline)] public static int3 operator &(int  a, int3 b) => new int3(a   & b.x, a   & b.y, a   & b.z);

		[MethodImpl(Inline)] public static int3 operator |(int3 a, int3 b) => new int3(a.x | b.x, a.y | b.y, a.z | b.z);
		[MethodImpl(Inline)] public static int3 operator |(int3 a, int  b) => new int3(a.x | b  , a.y | b  , a.z | b  );
		[MethodImpl(Inline)] public static int3 operator |(int  a, int3 b) => new int3(a   | b.x, a   | b.y, a   | b.z);

		[MethodImpl(Inline)] public static int3 operator ^(int3 a, int3 b) => new int3(a.x ^ b.x, a.y ^ b.y, a.z ^ b.z);
		[MethodImpl(Inline)] public static int3 operator ^(int3 a, int  b) => new int3(a.x ^ b  , a.y ^ b  , a.z ^ b  );
		[MethodImpl(Inline)] public static int3 operator ^(int  a, int3 b) => new int3(a   ^ b.x, a   ^ b.y, a   ^ b.z);

		[MethodImpl(Inline)] public static int3 operator -(int3 a) => new int3(-a.x, -a.y, -a.z);
		[MethodImpl(Inline)] public static int3 operator ~(int3 a) => new int3(~a.x, ~a.y, ~a.z);

		[MethodImpl(Inline)] public static int3 operator <<(int3 a, int b) => new int3(a.x << b, a.y << b, a.z << b);
		[MethodImpl(Inline)] public static int3 operator >>(int3 a, int b) => new int3(a.x >> b, a.y >> b, a.z >> b);
	}

	public static partial class math
	{
		[MethodImpl(Inline)] public static int3 int3(int x, int y, int z) => new int3(x, y, z);
		[MethodImpl(Inline)] public static int3 int3(int x) => new int3(x);
	}
}