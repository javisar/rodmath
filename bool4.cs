namespace RodMath
{
	public struct bool4
	{
		public bool x, y, z, w;

		public bool4(bool x, bool y, bool z, bool w)
		{
			this.x = x;
			this.y = y;
			this.z = z;
			this.w = w;
		}

		public bool4(bool x)
		{
			this.x = x;
			this.y = x;
			this.z = x;
			this.w = x;
		}
	}
}