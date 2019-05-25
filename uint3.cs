using System.Runtime.CompilerServices;

namespace RodMath
{
	public struct uint3
	{
		public uint x, y, z;

		public uint3(uint x, uint y, uint z)
		{
			this.x = x;
			this.y = y;
			this.z = z;
		}

		public uint3(uint x)
		{
			this.x = x;
			this.y = x;
			this.z = x;
		}

		public override bool Equals(object obj) => obj is uint3 a && math.all(this == a);
		public override int GetHashCode() => (int) (x ^ (y * 2718281) ^ (z * 314159));

		const MethodImplOptions Inline = MethodImplOptions.AggressiveInlining;

		[MethodImpl(Inline)] public static bool3 operator ==(uint3 a, uint3 b) => new bool3(a.x == b.x, a.y == b.y, a.z == b.z);
		[MethodImpl(Inline)] public static bool3 operator ==(uint3 a, uint  b) => new bool3(a.x == b  , a.y == b  , a.z == b  );
		[MethodImpl(Inline)] public static bool3 operator ==(uint  a, uint3 b) => new bool3(a   == b.x, a   == b.y, a   == b.z);

		[MethodImpl(Inline)] public static bool3 operator !=(uint3 a, uint3 b) => new bool3(a.x != b.x, a.y != b.y, a.z != b.z);
		[MethodImpl(Inline)] public static bool3 operator !=(uint3 a, uint  b) => new bool3(a.x != b  , a.y != b  , a.z != b  );
		[MethodImpl(Inline)] public static bool3 operator !=(uint  a, uint3 b) => new bool3(a   != b.x, a   != b.y, a   != b.z);

		[MethodImpl(Inline)] public static bool3 operator < (uint3 a, uint3 b) => new bool3(a.x <  b.x, a.y <  b.y, a.z <  b.z);
		[MethodImpl(Inline)] public static bool3 operator < (uint3 a, uint  b) => new bool3(a.x <  b  , a.y <  b  , a.z <  b  );
		[MethodImpl(Inline)] public static bool3 operator < (uint  a, uint3 b) => new bool3(a   <  b.x, a   <  b.y, a   <  b.z);

		[MethodImpl(Inline)] public static bool3 operator > (uint3 a, uint3 b) => new bool3(a.x >  b.x, a.y >  b.y, a.z >  b.z);
		[MethodImpl(Inline)] public static bool3 operator > (uint3 a, uint  b) => new bool3(a.x >  b  , a.y >  b  , a.z >  b  );
		[MethodImpl(Inline)] public static bool3 operator > (uint  a, uint3 b) => new bool3(a   >  b.x, a   >  b.y, a   >  b.z);

		[MethodImpl(Inline)] public static bool3 operator <=(uint3 a, uint3 b) => new bool3(a.x <= b.x, a.y <= b.y, a.z <= b.z);
		[MethodImpl(Inline)] public static bool3 operator <=(uint3 a, uint  b) => new bool3(a.x <= b  , a.y <= b  , a.z <= b  );
		[MethodImpl(Inline)] public static bool3 operator <=(uint  a, uint3 b) => new bool3(a   <= b.x, a   <= b.y, a   <= b.z);

		[MethodImpl(Inline)] public static bool3 operator >=(uint3 a, uint3 b) => new bool3(a.x >= b.x, a.y >= b.y, a.z >= b.z);
		[MethodImpl(Inline)] public static bool3 operator >=(uint3 a, uint  b) => new bool3(a.x >= b  , a.y >= b  , a.z >= b  );
		[MethodImpl(Inline)] public static bool3 operator >=(uint  a, uint3 b) => new bool3(a   >= b.x, a   >= b.y, a   >= b.z);

		[MethodImpl(Inline)] public static uint3 operator +(uint3 a, uint3 b) => new uint3(a.x + b.x, a.y + b.y, a.z + b.z);
		[MethodImpl(Inline)] public static uint3 operator +(uint3 a, uint  b) => new uint3(a.x + b  , a.y + b  , a.z + b  );
		[MethodImpl(Inline)] public static uint3 operator +(uint  a, uint3 b) => new uint3(a   + b.x, a   + b.y, a   + b.z);

		[MethodImpl(Inline)] public static uint3 operator -(uint3 a, uint3 b) => new uint3(a.x - b.x, a.y - b.y, a.z - b.z);
		[MethodImpl(Inline)] public static uint3 operator -(uint3 a, uint  b) => new uint3(a.x - b  , a.y - b  , a.z - b  );
		[MethodImpl(Inline)] public static uint3 operator -(uint  a, uint3 b) => new uint3(a   - b.x, a   - b.y, a   - b.z);

		[MethodImpl(Inline)] public static uint3 operator *(uint3 a, uint3 b) => new uint3(a.x * b.x, a.y * b.y, a.z * b.z);
		[MethodImpl(Inline)] public static uint3 operator *(uint3 a, uint  b) => new uint3(a.x * b  , a.y * b  , a.z * b  );
		[MethodImpl(Inline)] public static uint3 operator *(uint  a, uint3 b) => new uint3(a   * b.x, a   * b.y, a   * b.z);

		[MethodImpl(Inline)] public static uint3 operator /(uint3 a, uint3 b) => new uint3(a.x / b.x, a.y / b.y, a.z / b.z);
		[MethodImpl(Inline)] public static uint3 operator /(uint3 a, uint  b) => new uint3(a.x / b  , a.y / b  , a.z / b  );
		[MethodImpl(Inline)] public static uint3 operator /(uint  a, uint3 b) => new uint3(a   / b.x, a   / b.y, a   / b.z);

		[MethodImpl(Inline)] public static uint3 operator &(uint3 a, uint3 b) => new uint3(a.x & b.x, a.y & b.y, a.z & b.z);
		[MethodImpl(Inline)] public static uint3 operator &(uint3 a, uint  b) => new uint3(a.x & b  , a.y & b  , a.z & b  );
		[MethodImpl(Inline)] public static uint3 operator &(uint  a, uint3 b) => new uint3(a   & b.x, a   & b.y, a   & b.z);

		[MethodImpl(Inline)] public static uint3 operator |(uint3 a, uint3 b) => new uint3(a.x | b.x, a.y | b.y, a.z | b.z);
		[MethodImpl(Inline)] public static uint3 operator |(uint3 a, uint  b) => new uint3(a.x | b  , a.y | b  , a.z | b  );
		[MethodImpl(Inline)] public static uint3 operator |(uint  a, uint3 b) => new uint3(a   | b.x, a   | b.y, a   | b.z);

		[MethodImpl(Inline)] public static uint3 operator ^(uint3 a, uint3 b) => new uint3(a.x ^ b.x, a.y ^ b.y, a.z ^ b.z);
		[MethodImpl(Inline)] public static uint3 operator ^(uint3 a, uint  b) => new uint3(a.x ^ b  , a.y ^ b  , a.z ^ b  );
		[MethodImpl(Inline)] public static uint3 operator ^(uint  a, uint3 b) => new uint3(a   ^ b.x, a   ^ b.y, a   ^ b.z);

		[MethodImpl(Inline)] public static uint3 operator -(uint3 a) => new uint3((uint)-a.x, (uint)-a.y, (uint)-a.z);
		[MethodImpl(Inline)] public static uint3 operator ~(uint3 a) => new uint3(~a.x, ~a.y, ~a.z);

		[MethodImpl(Inline)] public static uint3 operator <<(uint3 a, int b) => new uint3(a.x << b, a.y << b, a.z << b);
		[MethodImpl(Inline)] public static uint3 operator >>(uint3 a, int b) => new uint3(a.x >> b, a.y >> b, a.z >> b);
	}

	public static partial class math
	{
		[MethodImpl(Inline)] public static uint3 uint3(uint x, uint y, uint z) => new uint3(x, y, z);
		[MethodImpl(Inline)] public static uint3 uint3(uint x) => new uint3(x);
	}
}