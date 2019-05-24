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
}