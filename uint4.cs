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

		public static bool4 operator ==(uint4 a, uint4 b) => new bool4 (a.x == b.x, a.y == b.y, a.z == b.z, a.w == b.w);
		public static bool4 operator ==(uint4 a, uint  b) => new bool4 (a.x == b  , a.y == b  , a.z == b  , a.w == b  );
		public static bool4 operator ==(uint  a, uint4 b) => new bool4 (a   == b.x, a   == b.y, a   == b.z, a   == b.w);

		public static bool4 operator !=(uint4 a, uint4 b) => new bool4 (a.x != b.x, a.y != b.y, a.z != b.z, a.w != b.w);
		public static bool4 operator !=(uint4 a, uint  b) => new bool4 (a.x != b  , a.y != b  , a.z != b  , a.w != b  );
		public static bool4 operator !=(uint  a, uint4 b) => new bool4 (a   != b.x, a   != b.y, a   != b.z, a   != b.w);

		public static bool4 operator < (uint4 a, uint4 b) => new bool4 (a.x <  b.x, a.y <  b.y, a.z <  b.z, a.w <  b.w);
		public static bool4 operator < (uint4 a, uint  b) => new bool4 (a.x <  b  , a.y <  b  , a.z <  b  , a.w <  b  );
		public static bool4 operator < (uint  a, uint4 b) => new bool4 (a   <  b.x, a   <  b.y, a   <  b.z, a   <  b.w);

		public static bool4 operator > (uint4 a, uint4 b) => new bool4 (a.x >  b.x, a.y >  b.y, a.z >  b.z, a.w >  b.w);
		public static bool4 operator > (uint4 a, uint  b) => new bool4 (a.x >  b  , a.y >  b  , a.z >  b  , a.w >  b  );
		public static bool4 operator > (uint  a, uint4 b) => new bool4 (a   >  b.x, a   >  b.y, a   >  b.z, a   >  b.w);

		public static bool4 operator <=(uint4 a, uint4 b) => new bool4 (a.x <= b.x, a.y <= b.y, a.z <= b.z, a.w <= b.w);
		public static bool4 operator <=(uint4 a, uint  b) => new bool4 (a.x <= b  , a.y <= b  , a.z <= b  , a.w <= b  );
		public static bool4 operator <=(uint  a, uint4 b) => new bool4 (a   <= b.x, a   <= b.y, a   <= b.z, a   <= b.w);

		public static bool4 operator >=(uint4 a, uint4 b) => new bool4 (a.x >= b.x, a.y >= b.y, a.z >= b.z, a.w >= b.w);
		public static bool4 operator >=(uint4 a, uint  b) => new bool4 (a.x >= b  , a.y >= b  , a.z >= b  , a.w >= b  );
		public static bool4 operator >=(uint  a, uint4 b) => new bool4 (a   >= b.x, a   >= b.y, a   >= b.z, a   >= b.w);

		public static uint4 operator +(uint4 a, uint4 b) => new uint4(a.x + b.x, a.y + b.y, a.z + b.z, a.w + b.w);
		public static uint4 operator +(uint4 a, uint  b) => new uint4(a.x + b  , a.y + b  , a.z + b  , a.w + b  );
		public static uint4 operator +(uint  a, uint4 b) => new uint4(a   + b.x, a   + b.y, a   + b.z, a   + b.w);

		public static uint4 operator -(uint4 a, uint4 b) => new uint4(a.x - b.x, a.y - b.y, a.z - b.z, a.w - b.w);
		public static uint4 operator -(uint4 a, uint  b) => new uint4(a.x - b  , a.y - b  , a.z - b  , a.w - b  );
		public static uint4 operator -(uint  a, uint4 b) => new uint4(a   - b.x, a   - b.y, a   - b.z, a   - b.w);

		public static uint4 operator *(uint4 a, uint4 b) => new uint4(a.x * b.x, a.y * b.y, a.z * b.z, a.w * b.w);
		public static uint4 operator *(uint4 a, uint  b) => new uint4(a.x * b  , a.y * b  , a.z * b  , a.w * b  );
		public static uint4 operator *(uint  a, uint4 b) => new uint4(a   * b.x, a   * b.y, a   * b.z, a   * b.w);

		public static uint4 operator /(uint4 a, uint4 b) => new uint4(a.x / b.x, a.y / b.y, a.z / b.z, a.w / b.w);
		public static uint4 operator /(uint4 a, uint  b) => new uint4(a.x / b  , a.y / b  , a.z / b  , a.w / b  );
		public static uint4 operator /(uint  a, uint4 b) => new uint4(a   / b.x, a   / b.y, a   / b.z, a   / b.w);

		public static uint4 operator &(uint4 a, uint4 b) => new uint4(a.x & b.x, a.y & b.y, a.z & b.z, a.w & b.w);
		public static uint4 operator &(uint4 a, uint  b) => new uint4(a.x & b  , a.y & b  , a.z & b  , a.w & b  );
		public static uint4 operator &(uint  a, uint4 b) => new uint4(a   & b.x,   a & b.y, a   & b.z, a   & b.w);

		public static uint4 operator |(uint4 a, uint4 b) => new uint4(a.x | b.x, a.y | b.y, a.z | b.z, a.w | b.w);
		public static uint4 operator |(uint4 a, uint  b) => new uint4(a.x | b  , a.y | b  , a.z | b  , a.w | b  );
		public static uint4 operator |(uint  a, uint4 b) => new uint4(a   | b.x,   a | b.y, a   | b.z, a   | b.w);

		public static uint4 operator ^(uint4 a, uint4 b) => new uint4(a.x ^ b.x, a.y ^ b.y, a.z ^ b.z, a.w ^ b.w);
		public static uint4 operator ^(uint4 a, uint  b) => new uint4(a.x ^ b  , a.y ^ b  , a.z ^ b  , a.w ^ b  );
		public static uint4 operator ^(uint  a, uint4 b) => new uint4(a   ^ b.x,   a ^ b.y, a   ^ b.z, a   ^ b.w);
	}

	public static partial class math
	{
		public static uint4 uint4(uint x, uint y, uint z, uint w) => new uint4(x, y, z, w);
		public static uint4 uint4(uint x) => new uint4(x);
	}
}