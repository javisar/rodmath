using System.Runtime.CompilerServices;

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

		public override bool Equals(object obj) => obj is bool3 a && math.all(this == a);
		public override int GetHashCode() => x.GetHashCode() ^ (y.GetHashCode() * 2718281) ^ (z.GetHashCode() * 314159);

		const MethodImplOptions Inline = MethodImplOptions.AggressiveInlining;

		[MethodImpl(Inline)] public static bool3 operator ==(bool3 a, bool3 b) => new bool3(a.x == b.x, a.y == b.y, a.z == b.z);
		[MethodImpl(Inline)] public static bool3 operator ==(bool3 a, bool  b) => new bool3(a.x == b  , a.y == b  , a.z == b  );
		[MethodImpl(Inline)] public static bool3 operator ==(bool  a, bool3 b) => new bool3(a   == b.x, a   == b.y, a   == b.z);

		[MethodImpl(Inline)] public static bool3 operator !=(bool3 a, bool3 b) => new bool3(a.x != b.x, a.y != b.y, a.z != b.z);
		[MethodImpl(Inline)] public static bool3 operator !=(bool3 a, bool  b) => new bool3(a.x != b  , a.y != b  , a.z != b  );
		[MethodImpl(Inline)] public static bool3 operator !=(bool  a, bool3 b) => new bool3(a   != b.x, a   != b.y, a   != b.z);

		[MethodImpl(Inline)] public static bool3 operator &(bool3 a, bool3 b) => new bool3(a.x & b.x, a.y & b.y, a.z & b.z);
		[MethodImpl(Inline)] public static bool3 operator &(bool3 a, bool  b) => new bool3(a.x & b  , a.y & b  , a.z & b  );
		[MethodImpl(Inline)] public static bool3 operator &(bool  a, bool3 b) => new bool3(a   & b.x, a   & b.y, a   & b.z);

		[MethodImpl(Inline)] public static bool3 operator |(bool3 a, bool3 b) => new bool3(a.x | b.x, a.y | b.y, a.z | b.z);
		[MethodImpl(Inline)] public static bool3 operator |(bool3 a, bool  b) => new bool3(a.x | b  , a.y | b  , a.z | b  );
		[MethodImpl(Inline)] public static bool3 operator |(bool  a, bool3 b) => new bool3(a   | b.x, a   | b.y, a   | b.z);

		[MethodImpl(Inline)] public static bool3 operator ^(bool3 a, bool3 b) => new bool3(a.x ^ b.x, a.y ^ b.y, a.z ^ b.z);
		[MethodImpl(Inline)] public static bool3 operator ^(bool3 a, bool  b) => new bool3(a.x ^ b  , a.y ^ b  , a.z ^ b  );
		[MethodImpl(Inline)] public static bool3 operator ^(bool  a, bool3 b) => new bool3(a   ^ b.x, a   ^ b.y, a   ^ b.z);

		[MethodImpl(Inline)] public static bool3 operator !(bool3 val) => new bool3(!val.x, !val.y, !val.z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override string ToString()
        {
            return string.Format("bool3({0}, {1}, {2}, {3})", x, y, z);
        }
    }

	public static partial class math
	{
		[MethodImpl(Inline)] public static bool3 bool3(bool x, bool y, bool z) => new bool3(x, y, z);
		[MethodImpl(Inline)] public static bool3 bool3(bool x) => new bool3(x);
	}
}