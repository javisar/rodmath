using System.Runtime.CompilerServices;

namespace RodMath
{
	public struct float2
	{
		public float x, y;

		public float2(float x, float y)
		{
			this.x = x;
			this.y = y;
		}

		public float2(float x)
		{
			this.x = x;
			this.y = x;
		}

		public override bool Equals(object obj) => obj is float2 a && math.all(this == a);
		public override int GetHashCode() => x.GetHashCode() ^ (y.GetHashCode() * 2718281);

		const MethodImplOptions Inline = MethodImplOptions.AggressiveInlining;

		[MethodImpl(Inline)] public static bool2 operator ==(float2 a, float2 b) => new bool2(a.x == b.x, a.y == b.y);
		[MethodImpl(Inline)] public static bool2 operator ==(float2 a, float  b) => new bool2(a.x == b  , a.y == b  );
		[MethodImpl(Inline)] public static bool2 operator ==(float  a, float2 b) => new bool2(a   == b.x, a   == b.y);

		[MethodImpl(Inline)] public static bool2 operator !=(float2 a, float2 b) => new bool2(a.x != b.x, a.y != b.y);
		[MethodImpl(Inline)] public static bool2 operator !=(float2 a, float  b) => new bool2(a.x != b  , a.y != b  );
		[MethodImpl(Inline)] public static bool2 operator !=(float  a, float2 b) => new bool2(a   != b.x, a   != b.y);

		[MethodImpl(Inline)] public static bool2 operator < (float2 a, float2 b) => new bool2(a.x <  b.x, a.y <  b.y);
		[MethodImpl(Inline)] public static bool2 operator < (float2 a, float  b) => new bool2(a.x <  b  , a.y <  b  );
		[MethodImpl(Inline)] public static bool2 operator < (float  a, float2 b) => new bool2(a   <  b.x, a   <  b.y);

		[MethodImpl(Inline)] public static bool2 operator > (float2 a, float2 b) => new bool2(a.x >  b.x, a.y >  b.y);
		[MethodImpl(Inline)] public static bool2 operator > (float2 a, float  b) => new bool2(a.x >  b  , a.y >  b  );
		[MethodImpl(Inline)] public static bool2 operator > (float  a, float2 b) => new bool2(a   >  b.x, a   >  b.y);

		[MethodImpl(Inline)] public static bool2 operator <=(float2 a, float2 b) => new bool2(a.x <= b.x, a.y <= b.y);
		[MethodImpl(Inline)] public static bool2 operator <=(float2 a, float  b) => new bool2(a.x <= b  , a.y <= b  );
		[MethodImpl(Inline)] public static bool2 operator <=(float  a, float2 b) => new bool2(a   <= b.x, a   <= b.y);

		[MethodImpl(Inline)] public static bool2 operator >=(float2 a, float2 b) => new bool2(a.x >= b.x, a.y >= b.y);
		[MethodImpl(Inline)] public static bool2 operator >=(float2 a, float  b) => new bool2(a.x >= b  , a.y >= b  );
		[MethodImpl(Inline)] public static bool2 operator >=(float  a, float2 b) => new bool2(a   >= b.x, a   >= b.y);

		[MethodImpl(Inline)] public static float2 operator +(float2 a, float2 b) => new float2(a.x + b.x, a.y + b.y);
		[MethodImpl(Inline)] public static float2 operator +(float2 a, float  b) => new float2(a.x + b  , a.y + b  );
		[MethodImpl(Inline)] public static float2 operator +(float  a, float2 b) => new float2(a   + b.x, a   + b.y);

		[MethodImpl(Inline)] public static float2 operator -(float2 a, float2 b) => new float2(a.x - b.x, a.y - b.y);
		[MethodImpl(Inline)] public static float2 operator -(float2 a, float  b) => new float2(a.x - b  , a.y - b  );
		[MethodImpl(Inline)] public static float2 operator -(float  a, float2 b) => new float2(a   - b.x, a   - b.y);

		[MethodImpl(Inline)] public static float2 operator *(float2 a, float2 b) => new float2(a.x * b.x, a.y * b.y);
		[MethodImpl(Inline)] public static float2 operator *(float2 a, float  b) => new float2(a.x * b  , a.y * b  );
		[MethodImpl(Inline)] public static float2 operator *(float  a, float2 b) => new float2(a   * b.x, a   * b.y);

		[MethodImpl(Inline)] public static float2 operator /(float2 a, float2 b) => new float2(a.x / b.x, a.y / b.y);
		[MethodImpl(Inline)] public static float2 operator /(float2 a, float  b) => new float2(a.x / b  , a.y / b  );
		[MethodImpl(Inline)] public static float2 operator /(float  a, float2 b) => new float2(a   / b.x, a   / b.y);

		[MethodImpl(Inline)] public static float2 operator -(float2 a) => new float2(-a.x, -a.y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override string ToString()
        {
            return string.Format("float2({0}, {1})", x, y);
        }
    }

	public static partial class math
	{
		[MethodImpl(Inline)] public static float2 float2(float x, float y) => new float2(x, y);
		[MethodImpl(Inline)] public static float2 float2(float x) => new float2(x);
	}
}