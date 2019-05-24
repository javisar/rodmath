namespace RodMath
{
	public struct uint2
	{
		public uint x, y;

		public uint2(uint x, uint y)
		{
			this.x = x;
			this.y = y;
		}

		public uint2(uint x)
		{
			this.x = x;
			this.y = x;
		}
	}

	public static partial class math
	{
		public static uint2 uint2(uint x, uint y) => new uint2(x, y);
		public static uint2 uint2(uint x) => new uint2(x);
	}
}