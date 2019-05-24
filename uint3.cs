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

		public static uint3 operator +(uint3 a, uint3 b) => new uint3(a.x + b.x, a.y + b.y, a.z + b.z);
		public static uint3 operator +(uint3 a, uint  b) => new uint3(a.x + b  , a.y + b  , a.z + b  );
		public static uint3 operator +(uint  a, uint3 b) => new uint3(a   + b.x, a   + b.y, a   + b.z);

		public static uint3 operator -(uint3 a, uint3 b) => new uint3(a.x - b.x, a.y - b.y, a.z - b.z);
		public static uint3 operator -(uint3 a, uint  b) => new uint3(a.x - b  , a.y - b  , a.z - b  );
		public static uint3 operator -(uint  a, uint3 b) => new uint3(a   - b.x, a   - b.y, a   - b.z);

		public static uint3 operator *(uint3 a, uint3 b) => new uint3(a.x * b.x, a.y * b.y, a.z * b.z);
		public static uint3 operator *(uint3 a, uint  b) => new uint3(a.x * b  , a.y * b  , a.z * b  );
		public static uint3 operator *(uint  a, uint3 b) => new uint3(a   * b.x, a   * b.y, a   * b.z);

		public static uint3 operator /(uint3 a, uint3 b) => new uint3(a.x / b.x, a.y / b.y, a.z / b.z);
		public static uint3 operator /(uint3 a, uint  b) => new uint3(a.x / b  , a.y / b  , a.z / b  );
		public static uint3 operator /(uint  a, uint3 b) => new uint3(a   / b.x, a   / b.y, a   / b.z);
	}

	public static partial class math
	{
		public static uint3 uint3(uint x, uint y, uint z) => new uint3(x, y, z);
		public static uint3 uint3(uint x) => new uint3(x);
	}
}