namespace RodMath
{
	public struct float4
	{
		public float x, y, z, w;

		public float4(float x, float y, float z, float w)
		{
			this.x = x;
			this.y = y;
			this.z = z;
			this.w = w;
		}

		public float4(float x)
		{
			this.x = x;
			this.y = x;
			this.z = x;
			this.w = x;
		}

		public static bool4 operator ==(float4 a, float4 b) => new bool4 (a.x == b.x, a.y == b.y, a.z == b.z, a.w == b.w);
		public static bool4 operator ==(float4 a, float  b) => new bool4 (a.x == b  , a.y == b  , a.z == b  , a.w == b  );
		public static bool4 operator ==(float  a, float4 b) => new bool4 (a   == b.x, a   == b.y, a   == b.z, a   == b.w);

		public static bool4 operator !=(float4 a, float4 b) => new bool4 (a.x != b.x, a.y != b.y, a.z != b.z, a.w != b.w);
		public static bool4 operator !=(float4 a, float  b) => new bool4 (a.x != b  , a.y != b  , a.z != b  , a.w != b  );
		public static bool4 operator !=(float  a, float4 b) => new bool4 (a   != b.x, a   != b.y, a   != b.z, a   != b.w);

		public static bool4 operator < (float4 a, float4 b) => new bool4 (a.x <  b.x, a.y <  b.y, a.z <  b.z, a.w <  b.w);
		public static bool4 operator < (float4 a, float  b) => new bool4 (a.x <  b  , a.y <  b  , a.z <  b  , a.w <  b  );
		public static bool4 operator < (float  a, float4 b) => new bool4 (a   <  b.x, a   <  b.y, a   <  b.z, a   <  b.w);

		public static bool4 operator > (float4 a, float4 b) => new bool4 (a.x >  b.x, a.y >  b.y, a.z >  b.z, a.w >  b.w);
		public static bool4 operator > (float4 a, float  b) => new bool4 (a.x >  b  , a.y >  b  , a.z >  b  , a.w >  b  );
		public static bool4 operator > (float  a, float4 b) => new bool4 (a   >  b.x, a   >  b.y, a   >  b.z, a   >  b.w);

		public static bool4 operator <=(float4 a, float4 b) => new bool4 (a.x <= b.x, a.y <= b.y, a.z <= b.z, a.w <= b.w);
		public static bool4 operator <=(float4 a, float  b) => new bool4 (a.x <= b  , a.y <= b  , a.z <= b  , a.w <= b  );
		public static bool4 operator <=(float  a, float4 b) => new bool4 (a   <= b.x, a   <= b.y, a   <= b.z, a   <= b.w);

		public static bool4 operator >=(float4 a, float4 b) => new bool4 (a.x >= b.x, a.y >= b.y, a.z >= b.z, a.w >= b.w);
		public static bool4 operator >=(float4 a, float  b) => new bool4 (a.x >= b  , a.y >= b  , a.z >= b  , a.w >= b  );
		public static bool4 operator >=(float  a, float4 b) => new bool4 (a   >= b.x, a   >= b.y, a   >= b.z, a   >= b.w);

		public static float4 operator +(float4 a, float4 b) => new float4(a.x + b.x, a.y + b.y, a.z + b.z, a.w + b.w);
		public static float4 operator +(float4 a, float  b) => new float4(a.x + b  , a.y + b  , a.z + b  , a.w + b  );
		public static float4 operator +(float  a, float4 b) => new float4(a   + b.x, a   + b.y, a   + b.z, a   + b.w);

		public static float4 operator -(float4 a, float4 b) => new float4(a.x - b.x, a.y - b.y, a.z - b.z, a.w - b.w);
		public static float4 operator -(float4 a, float  b) => new float4(a.x - b  , a.y - b  , a.z - b  , a.w - b  );
		public static float4 operator -(float  a, float4 b) => new float4(a   - b.x, a   - b.y, a   - b.z, a   - b.w);

		public static float4 operator *(float4 a, float4 b) => new float4(a.x * b.x, a.y * b.y, a.z * b.z, a.w * b.w);
		public static float4 operator *(float4 a, float  b) => new float4(a.x * b  , a.y * b  , a.z * b  , a.w * b  );
		public static float4 operator *(float  a, float4 b) => new float4(a   * b.x, a   * b.y, a   * b.z, a   * b.w);

		public static float4 operator /(float4 a, float4 b) => new float4(a.x / b.x, a.y / b.y, a.z / b.z, a.w / b.w);
		public static float4 operator /(float4 a, float  b) => new float4(a.x / b  , a.y / b  , a.z / b  , a.w / b  );
		public static float4 operator /(float  a, float4 b) => new float4(a   / b.x, a   / b.y, a   / b.z, a   / b.w);
	}

	public static partial class math
	{
		public static float4 float4(float x, float y, float z, float w) => new float4(x, y, z, w);
		public static float4 float4(float x) => new float4(x);
	}
}