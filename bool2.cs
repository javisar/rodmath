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
	}

	public static partial class math
	{
		[MethodImpl(Inline)] public static bool2 bool2(bool x, bool y) => new bool2(x, y);
		[MethodImpl(Inline)] public static bool2 bool2(bool x) => new bool2(x);
	}
}