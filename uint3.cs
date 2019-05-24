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
	}
}