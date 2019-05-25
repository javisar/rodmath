using System.Runtime.CompilerServices;

namespace RodMath
{
	public struct float3
	{
		public float x, y, z;

		public float3(float x, float y, float z)
		{
			this.x = x;
			this.y = y;
			this.z = z;
		}

		public float3(float x)
		{
			this.x = x;
			this.y = x;
			this.z = x;
		}

		const MethodImplOptions Inline = MethodImplOptions.AggressiveInlining;

		[MethodImpl(Inline)] public static bool3 operator ==(float3 a, float3 b) => new bool3(a.x == b.x, a.y == b.y, a.z == b.z);
		[MethodImpl(Inline)] public static bool3 operator ==(float3 a, float  b) => new bool3(a.x == b  , a.y == b  , a.z == b  );
		[MethodImpl(Inline)] public static bool3 operator ==(float  a, float3 b) => new bool3(a   == b.x, a   == b.y, a   == b.z);

		[MethodImpl(Inline)] public static bool3 operator !=(float3 a, float3 b) => new bool3(a.x != b.x, a.y != b.y, a.z != b.z);
		[MethodImpl(Inline)] public static bool3 operator !=(float3 a, float  b) => new bool3(a.x != b  , a.y != b  , a.z != b  );
		[MethodImpl(Inline)] public static bool3 operator !=(float  a, float3 b) => new bool3(a   != b.x, a   != b.y, a   != b.z);

		[MethodImpl(Inline)] public static bool3 operator < (float3 a, float3 b) => new bool3(a.x <  b.x, a.y <  b.y, a.z <  b.z);
		[MethodImpl(Inline)] public static bool3 operator < (float3 a, float  b) => new bool3(a.x <  b  , a.y <  b  , a.z <  b  );
		[MethodImpl(Inline)] public static bool3 operator < (float  a, float3 b) => new bool3(a   <  b.x, a   <  b.y, a   <  b.z);

		[MethodImpl(Inline)] public static bool3 operator > (float3 a, float3 b) => new bool3(a.x >  b.x, a.y >  b.y, a.z >  b.z);
		[MethodImpl(Inline)] public static bool3 operator > (float3 a, float  b) => new bool3(a.x >  b  , a.y >  b  , a.z >  b  );
		[MethodImpl(Inline)] public static bool3 operator > (float  a, float3 b) => new bool3(a   >  b.x, a   >  b.y, a   >  b.z);

		[MethodImpl(Inline)] public static bool3 operator <=(float3 a, float3 b) => new bool3(a.x <= b.x, a.y <= b.y, a.z <= b.z);
		[MethodImpl(Inline)] public static bool3 operator <=(float3 a, float  b) => new bool3(a.x <= b  , a.y <= b  , a.z <= b  );
		[MethodImpl(Inline)] public static bool3 operator <=(float  a, float3 b) => new bool3(a   <= b.x, a   <= b.y, a   <= b.z);

		[MethodImpl(Inline)] public static bool3 operator >=(float3 a, float3 b) => new bool3(a.x >= b.x, a.y >= b.y, a.z >= b.z);
		[MethodImpl(Inline)] public static bool3 operator >=(float3 a, float  b) => new bool3(a.x >= b  , a.y >= b  , a.z >= b  );
		[MethodImpl(Inline)] public static bool3 operator >=(float  a, float3 b) => new bool3(a   >= b.x, a   >= b.y, a   >= b.z);

		[MethodImpl(Inline)] public static float3 operator +(float3 a, float3 b) => new float3(a.x + b.x, a.y + b.y, a.z + b.z);
		[MethodImpl(Inline)] public static float3 operator +(float3 a, float  b) => new float3(a.x + b  , a.y + b  , a.z + b  );
		[MethodImpl(Inline)] public static float3 operator +(float  a, float3 b) => new float3(a   + b.x, a   + b.y, a   + b.z);

		[MethodImpl(Inline)] public static float3 operator -(float3 a, float3 b) => new float3(a.x - b.x, a.y - b.y, a.z - b.z);
		[MethodImpl(Inline)] public static float3 operator -(float3 a, float  b) => new float3(a.x - b  , a.y - b  , a.z - b  );
		[MethodImpl(Inline)] public static float3 operator -(float  a, float3 b) => new float3(a   - b.x, a   - b.y, a   - b.z);

		[MethodImpl(Inline)] public static float3 operator *(float3 a, float3 b) => new float3(a.x * b.x, a.y * b.y, a.z * b.z);
		[MethodImpl(Inline)] public static float3 operator *(float3 a, float  b) => new float3(a.x * b  , a.y * b  , a.z * b  );
		[MethodImpl(Inline)] public static float3 operator *(float  a, float3 b) => new float3(a   * b.x, a   * b.y, a   * b.z);

		[MethodImpl(Inline)] public static float3 operator /(float3 a, float3 b) => new float3(a.x / b.x, a.y / b.y, a.z / b.z);
		[MethodImpl(Inline)] public static float3 operator /(float3 a, float  b) => new float3(a.x / b  , a.y / b  , a.z / b  );
		[MethodImpl(Inline)] public static float3 operator /(float  a, float3 b) => new float3(a   / b.x, a   / b.y, a   / b.z);

		[MethodImpl(Inline)] public static float3 operator -(float3 a) => new float3(-a.x, -a.y, -a.z);
	}

	public static partial class math
	{
		[MethodImpl(Inline)] public static float3 float3(float x, float y, float z) => new float3(x, y, z);
		[MethodImpl(Inline)] public static float3 float3(float x) => new float3(x);
	}
}