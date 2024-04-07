using System.Runtime.CompilerServices;

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

		public override bool Equals(object obj) => obj is bool2 a && math.all(this == a);
		public override int GetHashCode() => x.GetHashCode() ^ (y.GetHashCode() * 2718281);

		const MethodImplOptions Inline = MethodImplOptions.AggressiveInlining;

		[MethodImpl(Inline)] public static bool2 operator ==(bool2 a, bool2 b) => new bool2(a.x == b.x, a.y == b.y);
		[MethodImpl(Inline)] public static bool2 operator ==(bool2 a, bool  b) => new bool2(a.x == b  , a.y == b  );
		[MethodImpl(Inline)] public static bool2 operator ==(bool  a, bool2 b) => new bool2(a   == b.x, a   == b.y);

		[MethodImpl(Inline)] public static bool2 operator !=(bool2 a, bool2 b) => new bool2(a.x != b.x, a.y != b.y);
		[MethodImpl(Inline)] public static bool2 operator !=(bool2 a, bool  b) => new bool2(a.x != b  , a.y != b  );
		[MethodImpl(Inline)] public static bool2 operator !=(bool  a, bool2 b) => new bool2(a   != b.x, a   != b.y);

		[MethodImpl(Inline)] public static bool2 operator &(bool2 a, bool2 b) => new bool2(a.x & b.x, a.y & b.y);
		[MethodImpl(Inline)] public static bool2 operator &(bool2 a, bool  b) => new bool2(a.x & b  , a.y & b  );
		[MethodImpl(Inline)] public static bool2 operator &(bool  a, bool2 b) => new bool2(a   & b.x, a   & b.y);

		[MethodImpl(Inline)] public static bool2 operator |(bool2 a, bool2 b) => new bool2(a.x | b.x, a.y | b.y);
		[MethodImpl(Inline)] public static bool2 operator |(bool2 a, bool  b) => new bool2(a.x | b  , a.y | b  );
		[MethodImpl(Inline)] public static bool2 operator |(bool  a, bool2 b) => new bool2(a   | b.x, a   | b.y);

		[MethodImpl(Inline)] public static bool2 operator ^(bool2 a, bool2 b) => new bool2(a.x ^ b.x, a.y ^ b.y);
		[MethodImpl(Inline)] public static bool2 operator ^(bool2 a, bool  b) => new bool2(a.x ^ b  , a.y ^ b  );
		[MethodImpl(Inline)] public static bool2 operator ^(bool  a, bool2 b) => new bool2(a   ^ b.x, a   ^ b.y);

		[MethodImpl(Inline)] public static bool2 operator !(bool2 val) => new bool2(!val.x, !val.y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override string ToString()
        {
            return string.Format("bool2({0}, {1})", x, y,);
        }
    }

	public static partial class math
	{
		[MethodImpl(Inline)] public static bool2 bool2(bool x, bool y) => new bool2(x, y);
		[MethodImpl(Inline)] public static bool2 bool2(bool x) => new bool2(x);
	}
}