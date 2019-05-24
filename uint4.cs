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
	}

	public static partial class math
	{
		public static uint4 uint4(uint x, uint y, uint z, uint w) => new uint4(x, y, z, w);
		public static uint4 uint4(uint x) => new uint4(x);
	}
}