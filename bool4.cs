using System.Runtime.CompilerServices;

namespace RodMath
{
	public struct bool4
	{
		public bool x, y, z, w;

		public bool4(bool x, bool y, bool z, bool w)
		{
			this.x = x;
			this.y = y;
			this.z = z;
			this.w = w;
		}

		public bool4(bool x)
		{
			this.x = x;
			this.y = x;
			this.z = x;
			this.w = x;
		}

		public override bool Equals(object obj) => obj is bool4 a && math.all(this == a);
		public override int GetHashCode() => x.GetHashCode() ^ (y.GetHashCode() * 2718281) ^ (z.GetHashCode() * 314159) ^ (w.GetHashCode() * 7071);

		const MethodImplOptions Inline = MethodImplOptions.AggressiveInlining;

		[MethodImpl(Inline)] public static bool4 operator ==(bool4 a, bool4 b) => new bool4(a.x == b.x, a.y == b.y, a.z == b.z, a.w == b.w);
		[MethodImpl(Inline)] public static bool4 operator ==(bool4 a, bool  b) => new bool4(a.x == b  , a.y == b  , a.z == b  , a.w == b  );
		[MethodImpl(Inline)] public static bool4 operator ==(bool  a, bool4 b) => new bool4(a   == b.x, a   == b.y, a   == b.z, a   == b.w);

		[MethodImpl(Inline)] public static bool4 operator !=(bool4 a, bool4 b) => new bool4(a.x != b.x, a.y != b.y, a.z != b.z, a.w != b.w);
		[MethodImpl(Inline)] public static bool4 operator !=(bool4 a, bool  b) => new bool4(a.x != b  , a.y != b  , a.z != b  , a.w != b  );
		[MethodImpl(Inline)] public static bool4 operator !=(bool  a, bool4 b) => new bool4(a   != b.x, a   != b.y, a   != b.z, a   != b.w);

		[MethodImpl(Inline)] public static bool4 operator &(bool4 a, bool4 b) => new bool4(a.x & b.x, a.y & b.y, a.z & b.z, a.w & b.w);
		[MethodImpl(Inline)] public static bool4 operator &(bool4 a, bool  b) => new bool4(a.x & b  , a.y & b  , a.z & b  , a.w & b  );
		[MethodImpl(Inline)] public static bool4 operator &(bool  a, bool4 b) => new bool4(a   & b.x,   a & b.y, a   & b.z, a   & b.w);

		[MethodImpl(Inline)] public static bool4 operator |(bool4 a, bool4 b) => new bool4(a.x | b.x, a.y | b.y, a.z | b.z, a.w | b.w);
		[MethodImpl(Inline)] public static bool4 operator |(bool4 a, bool  b) => new bool4(a.x | b  , a.y | b  , a.z | b  , a.w | b  );
		[MethodImpl(Inline)] public static bool4 operator |(bool  a, bool4 b) => new bool4(a   | b.x,   a | b.y, a   | b.z, a   | b.w);

		[MethodImpl(Inline)] public static bool4 operator ^(bool4 a, bool4 b) => new bool4(a.x ^ b.x, a.y ^ b.y, a.z ^ b.z, a.w ^ b.w);
		[MethodImpl(Inline)] public static bool4 operator ^(bool4 a, bool  b) => new bool4(a.x ^ b  , a.y ^ b  , a.z ^ b  , a.w ^ b  );
		[MethodImpl(Inline)] public static bool4 operator ^(bool  a, bool4 b) => new bool4(a   ^ b.x,   a ^ b.y, a   ^ b.z, a   ^ b.w);

		[MethodImpl(Inline)] public static bool4 operator !(bool4 val) => new bool4(!val.x, !val.y, !val.z, !val.w);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override string ToString()
        {
            return string.Format("bool4({0}, {1}, {2}, {3})", x, y, z, w);
        }
    }

	public static partial class math
	{
		[MethodImpl(Inline)] public static bool4 bool4(bool x, bool y, bool z, bool w) => new bool4(x, y, z, w);
		[MethodImpl(Inline)] public static bool4 bool4(bool x) => new bool4(x);
	}
}