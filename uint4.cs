using System.Runtime.CompilerServices;

namespace RodMath
{
	public struct uint4
	{
		public uint x, y, z, w;

		public uint4(uint x, uint y, uint z, uint w)
		{
			this.x = x;
			this.y = y;
			this.z = z;
			this.w = w;
		}

		public uint4(uint x)
		{
			this.x = x;
			this.y = x;
			this.z = x;
			this.w = x;
		}

		const MethodImplOptions Inline = MethodImplOptions.AggressiveInlining;

		[MethodImpl(Inline)] public static bool4 operator ==(uint4 a, uint4 b) => new bool4 (a.x == b.x, a.y == b.y, a.z == b.z, a.w == b.w);
		[MethodImpl(Inline)] public static bool4 operator ==(uint4 a, uint  b) => new bool4 (a.x == b  , a.y == b  , a.z == b  , a.w == b  );
		[MethodImpl(Inline)] public static bool4 operator ==(uint  a, uint4 b) => new bool4 (a   == b.x, a   == b.y, a   == b.z, a   == b.w);

		[MethodImpl(Inline)] public static bool4 operator !=(uint4 a, uint4 b) => new bool4 (a.x != b.x, a.y != b.y, a.z != b.z, a.w != b.w);
		[MethodImpl(Inline)] public static bool4 operator !=(uint4 a, uint  b) => new bool4 (a.x != b  , a.y != b  , a.z != b  , a.w != b  );
		[MethodImpl(Inline)] public static bool4 operator !=(uint  a, uint4 b) => new bool4 (a   != b.x, a   != b.y, a   != b.z, a   != b.w);

		[MethodImpl(Inline)] public static bool4 operator < (uint4 a, uint4 b) => new bool4 (a.x <  b.x, a.y <  b.y, a.z <  b.z, a.w <  b.w);
		[MethodImpl(Inline)] public static bool4 operator < (uint4 a, uint  b) => new bool4 (a.x <  b  , a.y <  b  , a.z <  b  , a.w <  b  );
		[MethodImpl(Inline)] public static bool4 operator < (uint  a, uint4 b) => new bool4 (a   <  b.x, a   <  b.y, a   <  b.z, a   <  b.w);

		[MethodImpl(Inline)] public static bool4 operator > (uint4 a, uint4 b) => new bool4 (a.x >  b.x, a.y >  b.y, a.z >  b.z, a.w >  b.w);
		[MethodImpl(Inline)] public static bool4 operator > (uint4 a, uint  b) => new bool4 (a.x >  b  , a.y >  b  , a.z >  b  , a.w >  b  );
		[MethodImpl(Inline)] public static bool4 operator > (uint  a, uint4 b) => new bool4 (a   >  b.x, a   >  b.y, a   >  b.z, a   >  b.w);

		[MethodImpl(Inline)] public static bool4 operator <=(uint4 a, uint4 b) => new bool4 (a.x <= b.x, a.y <= b.y, a.z <= b.z, a.w <= b.w);
		[MethodImpl(Inline)] public static bool4 operator <=(uint4 a, uint  b) => new bool4 (a.x <= b  , a.y <= b  , a.z <= b  , a.w <= b  );
		[MethodImpl(Inline)] public static bool4 operator <=(uint  a, uint4 b) => new bool4 (a   <= b.x, a   <= b.y, a   <= b.z, a   <= b.w);

		[MethodImpl(Inline)] public static bool4 operator >=(uint4 a, uint4 b) => new bool4 (a.x >= b.x, a.y >= b.y, a.z >= b.z, a.w >= b.w);
		[MethodImpl(Inline)] public static bool4 operator >=(uint4 a, uint  b) => new bool4 (a.x >= b  , a.y >= b  , a.z >= b  , a.w >= b  );
		[MethodImpl(Inline)] public static bool4 operator >=(uint  a, uint4 b) => new bool4 (a   >= b.x, a   >= b.y, a   >= b.z, a   >= b.w);

		[MethodImpl(Inline)] public static uint4 operator +(uint4 a, uint4 b) => new uint4(a.x + b.x, a.y + b.y, a.z + b.z, a.w + b.w);
		[MethodImpl(Inline)] public static uint4 operator +(uint4 a, uint  b) => new uint4(a.x + b  , a.y + b  , a.z + b  , a.w + b  );
		[MethodImpl(Inline)] public static uint4 operator +(uint  a, uint4 b) => new uint4(a   + b.x, a   + b.y, a   + b.z, a   + b.w);

		[MethodImpl(Inline)] public static uint4 operator -(uint4 a, uint4 b) => new uint4(a.x - b.x, a.y - b.y, a.z - b.z, a.w - b.w);
		[MethodImpl(Inline)] public static uint4 operator -(uint4 a, uint  b) => new uint4(a.x - b  , a.y - b  , a.z - b  , a.w - b  );
		[MethodImpl(Inline)] public static uint4 operator -(uint  a, uint4 b) => new uint4(a   - b.x, a   - b.y, a   - b.z, a   - b.w);

		[MethodImpl(Inline)] public static uint4 operator *(uint4 a, uint4 b) => new uint4(a.x * b.x, a.y * b.y, a.z * b.z, a.w * b.w);
		[MethodImpl(Inline)] public static uint4 operator *(uint4 a, uint  b) => new uint4(a.x * b  , a.y * b  , a.z * b  , a.w * b  );
		[MethodImpl(Inline)] public static uint4 operator *(uint  a, uint4 b) => new uint4(a   * b.x, a   * b.y, a   * b.z, a   * b.w);

		[MethodImpl(Inline)] public static uint4 operator /(uint4 a, uint4 b) => new uint4(a.x / b.x, a.y / b.y, a.z / b.z, a.w / b.w);
		[MethodImpl(Inline)] public static uint4 operator /(uint4 a, uint  b) => new uint4(a.x / b  , a.y / b  , a.z / b  , a.w / b  );
		[MethodImpl(Inline)] public static uint4 operator /(uint  a, uint4 b) => new uint4(a   / b.x, a   / b.y, a   / b.z, a   / b.w);

		[MethodImpl(Inline)] public static uint4 operator &(uint4 a, uint4 b) => new uint4(a.x & b.x, a.y & b.y, a.z & b.z, a.w & b.w);
		[MethodImpl(Inline)] public static uint4 operator &(uint4 a, uint  b) => new uint4(a.x & b  , a.y & b  , a.z & b  , a.w & b  );
		[MethodImpl(Inline)] public static uint4 operator &(uint  a, uint4 b) => new uint4(a   & b.x,   a & b.y, a   & b.z, a   & b.w);

		[MethodImpl(Inline)] public static uint4 operator |(uint4 a, uint4 b) => new uint4(a.x | b.x, a.y | b.y, a.z | b.z, a.w | b.w);
		[MethodImpl(Inline)] public static uint4 operator |(uint4 a, uint  b) => new uint4(a.x | b  , a.y | b  , a.z | b  , a.w | b  );
		[MethodImpl(Inline)] public static uint4 operator |(uint  a, uint4 b) => new uint4(a   | b.x,   a | b.y, a   | b.z, a   | b.w);

		[MethodImpl(Inline)] public static uint4 operator ^(uint4 a, uint4 b) => new uint4(a.x ^ b.x, a.y ^ b.y, a.z ^ b.z, a.w ^ b.w);
		[MethodImpl(Inline)] public static uint4 operator ^(uint4 a, uint  b) => new uint4(a.x ^ b  , a.y ^ b  , a.z ^ b  , a.w ^ b  );
		[MethodImpl(Inline)] public static uint4 operator ^(uint  a, uint4 b) => new uint4(a   ^ b.x,   a ^ b.y, a   ^ b.z, a   ^ b.w);

		[MethodImpl(Inline)] public static uint4 operator -(uint4 a) => new uint4((uint)-a.x, (uint)-a.y, (uint)-a.z, (uint)-a.w);
		[MethodImpl(Inline)] public static uint4 operator ~(uint4 a) => new uint4(~a.x, ~a.y, ~a.z, ~a.w);

		[MethodImpl(Inline)] public static uint4 operator <<(uint4 a, int b) => new uint4(a.x << b, a.y << b, a.z << b, a.w << b);
		[MethodImpl(Inline)] public static uint4 operator >>(uint4 a, int b) => new uint4(a.x >> b, a.y >> b, a.z >> b, a.w >> b);
	}

	public static partial class math
	{
		[MethodImpl(Inline)] public static uint4 uint4(uint x, uint y, uint z, uint w) => new uint4(x, y, z, w);
		[MethodImpl(Inline)] public static uint4 uint4(uint x) => new uint4(x);
	}
}